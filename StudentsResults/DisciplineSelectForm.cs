using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsResults
{
    public partial class DisciplineSelectForm : Form
    {
        DataBase dataBase = new DataBase();
        RB_Form Master;
        public int RB_Code;
        public DisciplineSelectForm(int RB_Code_, RB_Form master)
        {
            Master = master;
            RB_Code = RB_Code_;
            InitializeComponent();
            DisGridInit();
        }

        private void DisGridInit()
        {
            DataGridView grid = DisdataGridView;

            grid.Columns.Add("D_Code", "Код");
            grid.Columns[0].ReadOnly = true;
            grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[0].ReadOnly = true;
            grid.Columns.Add("Name", "Наименование");
            grid.Columns[1].ReadOnly = true;
            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns.Add("ProfessorName", "Преподаватель");
            grid.Columns[2].ReadOnly = true;
            grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            GridUpdate(grid, DisGridRequest(), DisReadRow);
        }
        private string DisGridRequest()
        {
            RB_Form MF = (RB_Form)this.Owner;
            
            int code = dataBase.ParseInt(DisCodeFilterBox.Text);
            string name = dataBase.ParseString(DisNameFilterBox.Text);
            string professor = dataBase.ParseString(DisProfessorFilterBox.Text);
            string Request = @"SELECT D_Code, 
                                    D.Name, 
                                    ISNULL(P.Name, '') as ProfessorName
                                FROM Discipline AS D LEFT JOIN Professor AS P ON
                                    FK_Professor = P_Code
                                WHERE D_Code NOT IN (
                                        SELECT L.FK_Discipline
                                        FROM Line AS L
                                        WHERE L.FK_RecordBook = " + RB_Code + ")";
            List<string> args = new List<string>();
            
            if (code != -1)
                args.Add(" AND D_Code = " + code);
            
            if (name != "")
                args.Add(string.Format(" AND D.Name LIKE '%{0}%'", name));
            
            if (professor != "")
                args.Add(string.Format(" AND P.Name LIKE '%{0}%'", professor));
            
            Request += String.Concat(args);
            return Request;
        }
        private void DisReadRow(DataGridView grid, IDataRecord record)
        {
            grid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
        }

        private void GridUpdate(DataGridView grid, string Request, Action<DataGridView, IDataRecord> ReadRow)
        {
            SqlCommand Command = new SqlCommand(Request, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = Command.ExecuteReader();

            grid.Rows.Clear();
            while (reader.Read())
            {
                ReadRow(grid, reader);
            }
            reader.Close();
        }

        private void DisdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var row = DisdataGridView.Rows[e.RowIndex];
            var id = row.Cells[0].Value;
            var name = row.Cells[1].Value;
            var secondName = row.Cells[2].Value;

            Master.SelectedCode = (int)id;
            Master.SelectedName = (string)name;
            Master.SelectedSecondName = (string)secondName;

            this.Close();
        }

        private void DisCodeFilterBox_TextChanged(object sender, EventArgs e)
        {
            GridUpdate(DisdataGridView, DisGridRequest(), DisReadRow);
        }

        private void DisNameFilterBox_TextChanged(object sender, EventArgs e)
        {
            GridUpdate(DisdataGridView, DisGridRequest(), DisReadRow);
        }

        private void DisProfessorFilterBox_TextChanged(object sender, EventArgs e)
        {
            GridUpdate(DisdataGridView, DisGridRequest(), DisReadRow);
        }
    }
}
