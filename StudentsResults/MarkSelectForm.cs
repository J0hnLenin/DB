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
    public partial class MarkSelectForm : Form
    {
        DataBase dataBase = new DataBase();
        public MarkSelectForm()
        {
            InitializeComponent();
            MarkGridInit();
        }

        private void MarkGridInit()
        {
            GridUpdate(MarkdataGridView, MarkGridRequest(), MarkReadRow);
        }
        private string MarkGridRequest()
        {
            string code = MarkCodeFilterBox.Text;
            string name = MarkNameFilterBox.Text;
            string Request = @"SELECT M_Code, Name FROM Mark ";
            List<string> args = new List<string>();
            if (code != "" || name != "")
            {
                args.Add("WHERE ");
                if (code != "")
                {
                    args.Add("M_Code = " + code);
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
        private void MarkReadRow(DataGridView grid, IDataRecord record)
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

        private void MarkdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var row = MarkdataGridView.Rows[e.RowIndex];
            var id = row.Cells[0].Value;
            RB_Form MF = (RB_Form)this.Owner;
            MF.SelectedCode = (int)id;

            this.Close();
        }
    }
}
