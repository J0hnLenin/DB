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

    public partial class RB_Form : Form
    {
        DataBase dataBase = new DataBase();

        MainForm master;

        public int RB_Code = -1;

        public RB_Form(int Code, MainForm master)
        {

            this.master = master;
            RB_Code = Code;
            InitializeComponent();
            RefreshHead();
            RefreshDataGrid(Line_DataGridView);
        }

        private void RefreshHead()
        {
            string Request = @"SELECT TOP 1
	                            RB_Code,
	                            RB.Name AS RB_Name,
	                            ISNULL(S_Code, '') AS S_Code,
                                ISNULL(S.Name, '') AS S_Name
                              FROM RecordBook AS RB LEFT JOIN Specialty AS S ON
	                            FK_Specialty = S_Code
                              WHERE RB_Code = " + RB_Code;

            SqlCommand Command = new SqlCommand(Request, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = Command.ExecuteReader();
            if (reader.Read())
            {
                CodeBox.Text = Convert.ToString(reader.GetInt32(0));
                NameBox.Text = reader.GetString(1);
                DisciplineCodeBox.Text = Convert.ToString(reader.GetInt32(2));
                SpecialtyNameBox.Text = reader.GetString(3);
            }
            reader.Close();
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string Request = @"SELECT
                                    L.L_Code AS L_Code,
	                                L.Number AS Number,
	                                ISNULL(D.Name, '') AS DisciplineName,
	                                ISNULL(M.Name, '') AS MarkName,
	                                L.Date AS Date,
	                                ISNULL(P.Name, '') AS ProfessorName,
                                    M.M_Code AS M_Code,
                                    D.D_Code AS D_Code
                                FROM RecordBook AS RB INNER JOIN Line AS L
	                                ON RB.RB_Code = L.FK_RecordBook
	                                LEFT JOIN Mark AS M ON
	                                L.FK_Mark = M.M_Code
	                                LEFT JOIN Discipline AS D ON
	                                L.FK_Discipline = D.D_Code
	                                LEFT JOIN Professor AS P ON
	                                D.FK_Professor = P.P_Code
                                WHERE RB.RB_Code = " + RB_Code + @"
                                ORDER BY L.Number";

            SqlCommand Command = new SqlCommand(Request, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                ReadRow(dgw, reader);
            }
            reader.Close();
        }
        private void ReadRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3),
                record.GetDateTime(4).ToString("d"), record.GetString(5),
                record.GetInt32(6), record.GetInt32(7));
        }

        private void Line_DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridView grid = Line_DataGridView;

            var row = grid.Rows[e.RowIndex];
            var id = row.Cells[0].Value;


            switch (e.ColumnIndex)
            {
                case 2:
                    {
                        SelectDiscipline(sender, e);
                        break;
                    }
                case 3:
                    {
                        SelectMark(sender, e);
                        break;
                    }
                case 4:
                    {
                        SelectDate(sender, e);
                        break;
                    }
            }

            if (id is null)
            {
                if (Check_Row(row))
                {
                    var property = new List<string> { "Number", "FK_RecordBook", "FK_Discipline", "FK_Mark", "Date" };

                    String number = Convert.ToString(grid.RowCount);
                    String rbook = Convert.ToString(RB_Code);
                    String disc = Convert.ToString(row.Cells[7].Value);
                    String mark = Convert.ToString(row.Cells[6].Value);
                    String date = Convert.ToString(row.Cells[4].Value);

                    var value = new List<string> { number, rbook, disc, mark, date };
                    dataBase.InsertObject("Line", property, value);

                    RefreshDataGrid(grid);
                }
            }
            else
            {
                UpdateLine(e.RowIndex);
            }
            
        }

        private void UpdateRow(DataGridViewRow R)
        {

            RefreshDataGrid(R.DataGridView);
        }

        private bool Check_Row(DataGridViewRow R)
        {
            if (R.Index == -1) return false;
            foreach (DataGridViewCell Cell in R.Cells)
            {
                if (Cell.ColumnIndex <= 1) continue;
                if (Cell.Value is null) return false;
                if (Cell.Value is string && (Cell.Value == "" || Cell.Value == " " || Cell.Value == "-1")) return false;
            }

            return true;
        }
        private void SpecialtyNameBox_Click(object sender, EventArgs e)
        {
            SelectSpecialty(sender, e);
        }
        private void SpecialtyCodeBox_Click(object sender, EventArgs e)
        {
            SelectSpecialty(sender, e);
        }

        public int SelectedCode = -1;
        private void SelectSpecialty(object sender, EventArgs e)
        {
            SelectedCode = -1;
            SpecialtySelectForm selectForm = new SpecialtySelectForm();
            selectForm.ShowDialog(this);
            if (SelectedCode != -1)
            {

                UpdateObject("RecordBook", "RB_Code", RB_Code, "FK_Specialty", Convert.ToString(SelectedCode));
                RefreshHead();
                SelectedCode = -1;
            }
        }
        private void SelectDiscipline(object sender, DataGridViewCellEventArgs e)
        {


            DataGridView grid = Line_DataGridView;

            SelectedCode = -1;
            SelectedName = "";
            SelectedSecondName = "";

            DisciplineSelectForm selectForm = new DisciplineSelectForm(RB_Code, this);
            selectForm.ShowDialog(this);
            if (SelectedCode != -1)
            {
                var row = grid.Rows[e.RowIndex];
                var id = row.Cells[0].Value;

                row.Cells[e.ColumnIndex].Value = Convert.ToString(SelectedName);
                row.Cells[7].Value = Convert.ToString(SelectedCode);
                row.Cells[5].Value = Convert.ToString(SelectedSecondName);

                SelectedCode = -1;
                SelectedName = "";
                SelectedSecondName = "";
            }

        }

        private void SelectMark(object sender, DataGridViewCellEventArgs e)
        {


            DataGridView grid = Line_DataGridView;

            SelectedCode = -1;
            SelectedName = "";

            MarkSelectForm selectForm = new MarkSelectForm();
            selectForm.ShowDialog(this);
            if (SelectedCode != -1)
            {
                var row = grid.Rows[e.RowIndex];
                var id = row.Cells[0].Value;

                row.Cells[e.ColumnIndex].Value = Convert.ToString(SelectedCode);
                row.Cells[6].Value = Convert.ToString(SelectedCode);

                SelectedCode = -1;
                SelectedName = "";

            }
        }
        public string SelectedName = "";
        public string SelectedSecondName = "";

        private void SelectDate(object sender, DataGridViewCellEventArgs e)
        {


            DataGridView grid = Line_DataGridView;

            SelectedName = "";
            DateSelectForm selectForm = new DateSelectForm();
            selectForm.ShowDialog(this);
            if (SelectedName != "")
            {
                var row = grid.Rows[e.RowIndex];
                var id = row.Cells[0].Value;
                row.Cells[e.ColumnIndex].Value = Convert.ToString(SelectedName);
                SelectedName = "";
            }
        }

        private void UpdateObject(string table, string id_name, int id, string property, string value)
        {
            value = dataBase.ParseString(value);
            var request = $"UPDATE {table} " +
                            $"SET {property} = '{value}' " +
                            $"WHERE {id_name} = {id};";

            SqlCommand Command = new SqlCommand(request, dataBase.getConnection());
            dataBase.openConnection();
            Command.ExecuteNonQuery();
        }

        private void UpdateLine(int Row)
        {
            DataGridView grid = Line_DataGridView;
            var row = grid.Rows[Row];
            String id = dataBase.ParseString(Convert.ToString(row.Cells[0].Value));
            String n = dataBase.ParseString(Convert.ToString(row.Cells[1].Value));
            String disc = dataBase.ParseString(Convert.ToString(row.Cells[7].Value));
            String mark = dataBase.ParseString(Convert.ToString(row.Cells[6].Value));
            String date = dataBase.ParseString(Convert.ToString(row.Cells[4].Value));

            var request = @$"UPDATE Line 
                            SET Number  = '{n}',
                                FK_Discipline  = '{disc}',
                                FK_Mark   = '{mark}',
                                Date  = '{date}'
                            WHERE L_Code = {id};";

            SqlCommand Command = new SqlCommand(request, dataBase.getConnection());
            dataBase.openConnection();
            Command.ExecuteNonQuery();
        }

        private void InsertObject(string table, string property, string value)
        {
            value = dataBase.ParseString(value);
            var request = $"INSERT INTO {table} ({property}) " +
                            $"VALUES ('{value}')";

            SqlCommand Command = new SqlCommand(request, dataBase.getConnection());
            dataBase.openConnection();
            Command.ExecuteNonQuery();
        }

        private void NameBox_Validated(object sender, EventArgs e)
        {
            UpdateObject("RecordBook", "RB_Code", RB_Code, "Name", NameBox.Text);
        }

        private void RB_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            master.GridUpdate("RecordBook");
        }

        private void Line_DataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            OnRowDeletion(Line_DataGridView, "Line", e);
        }

        private void DeleteObject(string table, string id_name, int id)
        {
            var request = $"DELETE FROM {table} " +
                            $"WHERE {id_name} = {id}";

            SqlCommand Command = new SqlCommand(request, dataBase.getConnection());
            dataBase.openConnection();
            Command.ExecuteNonQuery();
        }
        private void OnRowDeletion(DataGridView grid, string table, DataGridViewRowEventArgs e)
        {
            var row = e.Row;
            var id_name = "L_Code";
            var id = (int)row.Cells[0].Value;
            DeleteObject(table, id_name, id);
            RefreshDataGrid(grid);
        }

    }
}
