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
        int RB_Code = -1;
        public RB_Form(int Code)
        {
            RB_Code = Code;
            InitializeComponent();
            RefreshHead();
            CreateColumns();
            RefreshDataGrid(Line_DataGridView);
        }

        private void CreateColumns()
        {
            Line_DataGridView.Columns.Add("Number", "№");
            Line_DataGridView.Columns.Add("DisciplineName", "Дисциплина");
            Line_DataGridView.Columns.Add("MarkName", "Оценка");
            Line_DataGridView.Columns.Add("Date", "Дата экзамена");
            Line_DataGridView.Columns.Add("ProfessorName", "Преподаватель");

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
                DisciplineNameBox.Text = reader.GetString(3);
            }
            reader.Close();
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string Request = @"SELECT
	                                L.Number AS Number,
	                                ISNULL(D.Name, '') AS DisciplineName,
	                                ISNULL(M.Name, '') AS MarkName,
	                                L.Date AS Date,
	                                ISNULL(P.Name, '') AS ProfessorName
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
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetDateTime(3).ToString("d"), record.GetString(4));
        }
    }
}
