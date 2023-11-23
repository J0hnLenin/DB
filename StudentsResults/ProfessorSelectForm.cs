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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentsResults
{
    public partial class ProfessorSelectForm : Form
    {
        DataBase dataBase = new DataBase();
        int selected_row = -1;
        public ProfessorSelectForm()
        {
            InitializeComponent();
            ProfGridInit();
        }

        public (int, string) GetProf(Form Owner)
        {
            this.ShowDialog(Owner);
            if (selected_row == -1)
                return (-1, "");
            var row = ProfdataGridView.Rows[selected_row];
            var prof_id = dataBase.ParseInt(Convert.ToString(row.Cells[0].Value));
            var name = dataBase.ParseString(Convert.ToString(row.Cells[1].Value));
            return (prof_id, name);
        }

        private void ProfdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            selected_row = e.RowIndex;
            var row = ProfdataGridView.Rows[e.RowIndex];
            var id = row.Cells[0].Value;
            MainForm MF = (MainForm)this.Owner;
            MF.SelectedCode = (int)id;

            this.Close();

        }

        private void ProfGridInit()
        {


            ProfdataGridView.Columns.Add("P_Code", "Код");
            ProfdataGridView.Columns[0].ReadOnly = true;
            ProfdataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ProfdataGridView.Columns.Add("Name", "ФИО");
            ProfdataGridView.Columns[1].ReadOnly = true;
            ProfdataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            GridUpdate(ProfdataGridView, ProfGridRequest(), ProfReadRow);
        }
        private string ProfGridRequest()
        {
            int code = dataBase.ParseInt(ProfCodeFilterBox.Text);
            string name = dataBase.ParseString(ProfNameFilterBox.Text);
            string Request = @"SELECT P_Code, Name FROM Professor ";
            List<string> args = new List<string>();
            if (code != -1 || name != "")
            {
                args.Add("WHERE ");
                if (code != -1)
                {
                    args.Add("P_Code = " + code);
                }
                if (name != "")
                {
                    if (args.Count() > 1)
                        args.Add(" AND ");
                    args.Add(string.Format("Name LIKE '%{0}%'", name));
                }
            }
            Request += String.Concat(args);
            return Request;
        }
        private void ProfReadRow(DataGridView grid, IDataRecord record)
        {
            grid.Rows.Add(record.GetInt32(0), record.GetString(1));
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

        private void ProfCodeFilterBox_TextChanged(object sender, EventArgs e)
        {
            GridUpdate(ProfdataGridView, ProfGridRequest(), ProfReadRow);
        }

        private void ProfNameFilterBox_TextChanged(object sender, EventArgs e)
        {
            GridUpdate(ProfdataGridView, ProfGridRequest(), ProfReadRow);
        }
    }
}
