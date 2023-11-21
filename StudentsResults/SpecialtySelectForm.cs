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
    public partial class SpecialtySelectForm : Form
    {
        DataBase dataBase = new DataBase();
        public SpecialtySelectForm()
        {
            InitializeComponent();
            SpGridInit();
        }
        private void SpGridInit()
        {
            GridUpdate(SpdataGridView, SpGridRequest(), SpReadRow);
        }
        private string SpGridRequest()
        {
            int code = dataBase.ParseInt(SpCodeFilterBox.Text);
            string name = dataBase.ParseString(SpNameFilterBox.Text);
            string Request = @"SELECT S_Code, Name from Specialty ";
            List<string> args = new List<string>();
            if (code != -1 || name != "")
            {
                args.Add("WHERE ");
                if (code != -1)
                {
                    args.Add("S_code = " + code);
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
        private void SpReadRow(DataGridView grid, IDataRecord record)
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

        private void SpdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var row = SpdataGridView.Rows[e.RowIndex];
            var id = row.Cells[0].Value;
            RB_Form MF = (RB_Form)this.Owner;
            MF.SelectedCode = (int)id;

            this.Close();
        }

        private void SpCodeFilterBox_TextChanged(object sender, EventArgs e)
        {
            GridUpdate(SpdataGridView, SpGridRequest(), SpReadRow);
        }

        private void SpNameFilterBox_TextChanged(object sender, EventArgs e)
        {
            GridUpdate(SpdataGridView, SpGridRequest(), SpReadRow);
        }
    }
}
