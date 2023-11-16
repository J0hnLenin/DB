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
        public DisciplineSelectForm()
        {
            InitializeComponent();
            DisGridInit();
        }

        private void DisGridInit()
        {
            DataGridView grid = DisdataGridView;

            grid.Columns.Add("D_Code", "Код");
            grid.Columns.Add("Name", "Наименование");
            grid.Columns.Add("ProfessorName", "Преподаватель");

            GridUpdate(grid, DisGridRequest(), DisReadRow);
        }
        private string DisGridRequest()
        {
            string code = DisCodeFilterBox.Text;
            string name = DisNameFilterBox.Text;
            string professor = DisProfessorFilterBox.Text;
            string Request = @"SELECT D_Code, D.Name, ISNULL(P.Name, '') as ProfessorName
                               FROM Discipline AS D LEFT JOIN Professor AS P ON
                               FK_Professor = P_Code ";
            List<string> args = new List<string>();
            if (code != "" || name != "" || professor != "")
            {
                args.Add("WHERE ");
                if (code != "")
                {
                    args.Add("D_Code = " + code);
                }
                if (name != "")
                {
                    if (args.Count() > 1)
                        args.Add(" AND ");
                    args.Add(string.Format("D.Name LIKE '%{0}%'", name));
                }
                if (professor != "")
                {
                    if (args.Count() > 1)
                        args.Add(" AND ");
                    args.Add(string.Format("P.Name LIKE '%{0}%'", professor));
                }
            }
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
            RB_Form MF = (RB_Form)this.Owner;
            MF.SelectedCode = (int)id;

            this.Close();
        }
    }
}
