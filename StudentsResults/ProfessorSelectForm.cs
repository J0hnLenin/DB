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
        public ProfessorSelectForm()
        {
            InitializeComponent();
            ProfGridInit();
        }

        private void ProfdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = ProfdataGridView.Rows[e.RowIndex];
            var id = row.Cells[0].Value;
            MainForm MF = (MainForm)this.Owner;
            MF.SelectedCode = (int)id;

            this.Close();

        }

        private void ProfGridInit()
        {
            DataGridView grid = ProfdataGridView;

            grid.Columns.Add("P_Code", "Код");
            grid.Columns.Add("Name", "ФИО");

            GridUpdate(grid, ProfGridRequest(), ProfReadRow);
        }
        private string ProfGridRequest()
        {
            string code = ProfCodeFilterBox.Text;
            string name = ProfNameFilterBox.Text;
            string Request = @"SELECT P_Code, Name FROM Professor ";
            List<string> args = new List<string>();
            if (code != "" || name != "")
            {
                args.Add("WHERE ");
                if (code != "")
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
    }
}
