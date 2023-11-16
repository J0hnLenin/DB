using Microsoft.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms;
using Azure.Core;


namespace StudentsResults
{
    enum RowState
    {
        Existed,
        New,
        Deleted,
        Modified,
        ModifiedNew
    }
    public partial class MainForm : Form
    {
        DataBase dataBase = new DataBase();
        
        public MainForm()
        {
            InitializeComponent();
            CreateColumns();
            RefreshDataGrid(RB_DataGridView);
            SpGridInit();
            DisGridInit();
            ProfGridInit();
            MarkGridInit();
        }

        //Marks grid
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


        //Discipline grid
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

        //Professor grid
        private void ProfGridInit()
        {
            GridUpdate(ProfdataGridView, ProfGridRequest(), ProfReadRow);
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

        //Specialty grid
        private void SpGridInit()
        {
            GridUpdate(SpdataGridView, SpGridRequest(), SpReadRow);
        }
        private string SpGridRequest()
        {
            string code = SpCodeFilterBox.Text;
            string name = SpNameFilterBox.Text;
            string Request = @"SELECT S_Code, Name from Specialty ";
            List<string> args = new List<string>();
            if (code != "" || name != "")
            {
                args.Add("WHERE ");
                if (code != "")
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

        private void GridUpdate(string table_name)
        {
            switch (table_name)
            {
                case "Professor":
                    ProfGridInit();
                    break;
                case "Discipline":
                    DisGridInit();
                    break;
                case "Specialty":
                    SpGridInit();
                    break;
                case "Mark":
                    MarkGridInit();
                    break;
            }
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
        private void UpdateObject(string table, string id_name, int id, string property, string value)
        {
            var request = $"UPDATE {table} " +
                            $"SET {property} = '{value}' " +
                            $"WHERE {id_name} = {id};";

            SqlCommand Command = new SqlCommand(request, dataBase.getConnection());
            dataBase.openConnection();
            Command.ExecuteNonQuery();
        }
        private void InsertObject(string table, string property, string value)
        {
            var request = $"INSERT INTO {table} ({property}) " +
                            $"VALUES ('{value}')";

            SqlCommand Command = new SqlCommand(request, dataBase.getConnection());
            dataBase.openConnection();
            Command.ExecuteNonQuery();
        }
        private void DeleteObject(string table, string id_name, int id)
        {
            var request = $"DELETE FROM {table} " +
                            $"WHERE {id_name} = {id}";

            SqlCommand Command = new SqlCommand(request, dataBase.getConnection());
            dataBase.openConnection();
            Command.ExecuteNonQuery();
        }

        private void CreateColumns()
        {

            RB_DataGridView.Columns.Add("RB_Code", "Код");
            RB_DataGridView.Columns.Add("Name", "ФИО");
            RB_DataGridView.Columns.Add("SpecialtyName", "Направление подготовки");

            //RB_DataGridView.Columns.Add("State", "State");

        }

        private void ReadRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string Request = @"SELECT 
	                            RB_Code,
	                            R.Name,
	                            ISNULL(S.Name, '') AS SpecialtyName
                              FROM RecordBook AS R LEFT JOIN Specialty AS S ON
	                            FK_Specialty = S_Code";
            if (CodeFilterBox.Text != "" || NameFilterBox.Text != "" || DisciplineFilterBox.Text != "")
            {
                bool Flag = false;
                Request = string.Format("{0} WHERE", Request);

                if (CodeFilterBox.Text != "")
                {
                    if (Flag)
                    {
                        Request = string.Format("{0} AND", Request);
                    }
                    Request = string.Format("{0} RB_Code = {1}", Request, CodeFilterBox.Text);
                    Flag = true;
                }
                if (NameFilterBox.Text != "")
                {
                    if (Flag)
                    {
                        Request = string.Format("{0} AND", Request);
                    }
                    Request = string.Format("{0} R.Name LIKE '%{1}%'", Request, NameFilterBox.Text);
                    Flag = true;
                }
                if (DisciplineFilterBox.Text != "")
                {
                    if (Flag)
                    {
                        Request = string.Format("{0} AND", Request);
                    }
                    Request = string.Format("{0} S.Name LIKE '%{1}%'", Request, DisciplineFilterBox.Text);
                    Flag = true;
                }
            }

            SqlCommand Command = new SqlCommand(Request, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                ReadRow(dgw, reader);
            }
            reader.Close();
        }

        private void RB_DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            RB_Form New_RB_Form = new RB_Form(Convert.ToInt32(RB_DataGridView.Rows[e.RowIndex].Cells[0].Value));
            New_RB_Form.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NameFilterBox_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(RB_DataGridView);
        }

        private void CodeFilterBox_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(RB_DataGridView);
        }

        private void DisciplineFilterBox_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(RB_DataGridView);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ProfdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SpCodeFilterBox_TextChanged(object sender, EventArgs e)
        {
            GridUpdate(SpdataGridView, SpGridRequest(), SpReadRow);
        }

        private void SpNameFilterBox_TextChanged(object sender, EventArgs e)
        {
            GridUpdate(SpdataGridView, SpGridRequest(), SpReadRow);
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

        private void ProfCodeFilterBox_TextChanged(object sender, EventArgs e)
        {
            GridUpdate(ProfdataGridView, ProfGridRequest(), ProfReadRow);
        }

        private void ProfNameFilterBox_TextChanged(object sender, EventArgs e)
        {
            GridUpdate(ProfdataGridView, ProfGridRequest(), ProfReadRow);
        }

        private void MarkCodeFilterBox_TextChanged(object sender, EventArgs e)
        {
            GridUpdate(MarkdataGridView, MarkGridRequest(), MarkReadRow);
        }

        private void MarkNameFilterBox_TextChanged(object sender, EventArgs e)
        {
            GridUpdate(MarkdataGridView, MarkGridRequest(), MarkReadRow);
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void OnCellChange(DataGridView grid, string table, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var row = grid.Rows[e.RowIndex];
            var id_name = grid.Columns[0].Name.Substring(2);
            var id = row.Cells[0].Value;
            var property = grid.Columns[e.ColumnIndex].Name.Substring(2);
            var value = (string)row.Cells[e.ColumnIndex].Value;
            if (id is not null)
            {
                UpdateObject(table, id_name, (int)id, property, value);
            }
            else
            {
                InsertObject(table, property, value);
            }

            GridUpdate(table);
        }

        private void OnRowDeletion(DataGridView grid, string table, DataGridViewRowEventArgs e)
        {
            var row = e.Row;
            var id_name = grid.Columns[0].Name.Substring(2);
            var id = (int)row.Cells[0].Value;
            DeleteObject(table, id_name, id);
            GridUpdate(table);
        }

        private void MarkdataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            OnCellChange(MarkdataGridView, "Mark", e);
        }

        private void MarkdataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            OnRowDeletion(MarkdataGridView, "Mark", e);
        }

        private void GetReport_Click(object sender, EventArgs e)
        {
            if (ReportComboBox.SelectedIndex == -1)
                return;

            int id = (int)ReportComboBox.SelectedIndex;
            ReportCreateColumns(id);
            RefreshReportDataGrid(ReportDataGridView, id);
        }

        private void ReportCreateColumns(int id)
        {
            switch (id)
            {
                case 0:
                    {
                        ReportDataGridView.Columns.Clear();
                        ReportDataGridView.Columns.Add("RB_Code", "Зачётная книга");
                        ReportDataGridView.Columns.Add("RB_Name", "ФИО");
                        ReportDataGridView.Columns.Add("SpecialtyName", "Направление подготовки");
                        ReportDataGridView.Columns.Add("DisciplineName", "Дисциплина");
                        ReportDataGridView.Columns.Add("MarkName", "Оценка");
                        ReportDataGridView.Columns.Add("Date", "Дата экзамена");
                        break;
                    }
                case 1:
                    {
                        ReportDataGridView.Columns.Clear();
                        ReportDataGridView.Columns.Add("Number", "Количество студентов");
                        ReportDataGridView.Columns.Add("SpecialtyName", "Направление подготовки");
                        ReportDataGridView.Columns.Add("DisciplineName", "Дисциплина");
                        ReportDataGridView.Columns.Add("MarkName", "Оценка");
                        break;
                    }
            }

        }

        private void ReportReadRow(DataGridView dgw, IDataRecord record, int id)
        {
            switch (id)
            {
                case 0:
                    {
                        dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetDateTime(5).ToString("d"));
                        break;
                    }
                case 1:
                    {
                        dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3));
                        break;
                    }

            }
        }

        private void RefreshReportDataGrid(DataGridView dgw, int id)
        {
            dgw.Rows.Clear();
            string Request = "";
            switch (id)
            {
                case 0:
                    {
                        Request = @"SELECT
	                        RB_Code,
	                        RB.Name AS RB_Name,
	                        ISNULL(S.Name, '') AS SpecialityName,
	                        ISNULL(D.Name, '') AS DisciplineName,
	                        ISNULL(M.Name, '') AS MarkName,
	                        Date
                        FROM RecordBook AS RB INNER JOIN Line AS L ON
	                        RB_Code = FK_RecordBook
	                        LEFT JOIN Mark AS M ON 
	                        M_Code = FK_Mark
	                        LEFT JOIN Specialty AS S ON
	                        S_Code = FK_Specialty
	                        LEFT JOIN Discipline AS D ON
	                        D_Code = FK_Discipline";
                        break;
                    }
                case 1:
                    {
                        Request = @"SELECT
	                        COUNT(RB_Code) AS NUMBER,
	                        ISNULL(S.Name, '') AS SpecialityName,
	                        ISNULL(D.Name, '') AS DisciplineName,
	                        ISNULL(M.Name, '') AS MarkName
                        FROM RecordBook AS RB INNER JOIN Line AS L ON
	                        RB_Code = FK_RecordBook
	                        LEFT JOIN Mark AS M ON 
	                        M_Code = FK_Mark
	                        LEFT JOIN Specialty AS S ON
	                        S_Code = FK_Specialty
	                        LEFT JOIN Discipline AS D ON
	                        D_Code = FK_Discipline";
                        break;
                    }
            }

            if (SFilterBox.Text != "" || DFilterBox.Text != "" || MFilterBox.Text != "")
            {
                bool Flag = false;
                Request = string.Format("{0} WHERE", Request);

                if (SFilterBox.Text != "")
                {
                    if (Flag)
                    {
                        Request = string.Format("{0} AND", Request);
                    }
                    Request = string.Format("{0} S.Name LIKE '%{1}%'", Request, SFilterBox.Text);
                    Flag = true;
                }
                if (DFilterBox.Text != "")
                {
                    if (Flag)
                    {
                        Request = string.Format("{0} AND", Request);
                    }
                    Request = string.Format("{0} D.Name LIKE '%{1}%'", Request, DFilterBox.Text);
                    Flag = true;
                }
                if (MFilterBox.Text != "")
                {
                    if (Flag)
                    {
                        Request = string.Format("{0} AND", Request);
                    }
                    Request = string.Format("{0} M.Name LIKE '%{1}%'", Request, MFilterBox.Text);
                    Flag = true;
                }
            }
            switch (id)
            {
                case 0:
                    break;
                case 1:
                    {
                        Request = string.Format(@"{0}
                                                GROUP BY
                                                    S.Name,
                                                    D.Name,
                                                    M.Name", Request);
                        break;
                    }
            }


            SqlCommand Command = new SqlCommand(Request, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = Command.ExecuteReader();
            while (reader.Read())
            {
                ReportReadRow(dgw, reader, id);
            }
            reader.Close();
        }

        private void ReportDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void ProfdataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            OnCellChange(ProfdataGridView, "Professor", e);
        }

        private void ProfdataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            OnRowDeletion(ProfdataGridView, "Professor", e);
        }

        private void SpdataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            OnCellChange(SpdataGridView, "Specialty", e);
        }

        private void SpdataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            OnRowDeletion(SpdataGridView, "Specialty", e);
        }

        public int SelectedCode = -1;
        private void DisdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex == -1 || e.ColumnIndex != 2) 
                return;
            DataGridView grid = DisdataGridView;

            SelectedCode = -1;
            ProfessorSelectForm selectForm = new ProfessorSelectForm();
            selectForm.ShowDialog(this);
            if (SelectedCode != -1)
            {
                var row = grid.Rows[e.RowIndex];
                var id = row.Cells[0].Value;
                UpdateObject("Discipline", "D_Code", (int)id, "FK_Professor", Convert.ToString(SelectedCode));
                GridUpdate(grid, DisGridRequest(), DisReadRow);
                SelectedCode = -1;
            }
        }
    }
}