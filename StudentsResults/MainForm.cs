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
            RBGridInit();
            SpGridInit();
            DisGridInit();
            ProfGridInit();
            MarkGridInit();
        }

        //Marks grid
        private void MarkGridInit()
        {
            GridUpdate(MarkdataGridView, MarkGridRequest(), MarkReadRow);
            MarkdataGridView.Sort(MarkdataGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
        }
        private string MarkGridRequest()
        {
            int code = dataBase.ParseInt(MarkCodeFilterBox.Text);
            string name = dataBase.ParseString(MarkNameFilterBox.Text);
            string Request = @"SELECT M_Code, Name FROM Mark ";
            List<string> args = new List<string>();
            if (code != -1 || name != "")
            {
                args.Add("WHERE ");
                if (code != -1)
                {
                    args.Add($"M_Code = '{code}'");
                }
                if (name != "")
                {
                    if (args.Count() > 1)
                        args.Add(" AND ");
                    args.Add(string.Format("Name LIKE '%{0}%'", name));
                }
            }
            args.Add(" ORDER BY Name");
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
            GridUpdate(DisdataGridView, DisGridRequest(), DisReadRow);
            var grid = DisdataGridView;
            grid.Sort(grid.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
        }
        private string DisGridRequest()
        {
            int code = dataBase.ParseInt(DisCodeFilterBox.Text);
            string name = dataBase.ParseString(DisNameFilterBox.Text);
            string professor = dataBase.ParseString(DisProfessorFilterBox.Text);
            string Request = @"SELECT D_Code, D.Name, ISNULL(P.Name, '') as ProfessorName
                               FROM Discipline AS D LEFT JOIN Professor AS P ON
                               FK_Professor = P_Code ";
            List<string> args = new List<string>();
            if (code != -1 || name != "" || professor != "")
            {
                args.Add("WHERE ");
                if (code != -1)
                {
                    args.Add($"D_Code = '{code}'");
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
            args.Add(" ORDER BY D.Name");
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
            var grid = ProfdataGridView;
            grid.Sort(grid.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
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
                    args.Add($"P_Code = '{code}'");
                }
                if (name != "")
                {
                    if (args.Count() > 1)
                        args.Add(" AND ");
                    args.Add(string.Format("Name LIKE '%{0}%'", name));
                }
            }
            args.Add(" ORDER BY Name");
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
            var grid = SpdataGridView;
            grid.Sort(grid.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
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
                    args.Add($"S_code = '{code}'");
                }
                if (name != "")
                {
                    if (args.Count() > 1)
                        args.Add(" AND ");
                    args.Add(string.Format("Name LIKE '%{0}%'", name));
                }
            }
            args.Add(" ORDER BY Name");
            Request += String.Concat(args);
            return Request;
        }
        private void SpReadRow(DataGridView grid, IDataRecord record)
        {
            grid.Rows.Add(record.GetInt32(0), record.GetString(1));
        }

        //RecordBook
        private void RBGridInit()
        {
            GridUpdate(RB_DataGridView, RBGridRequest(), RBReadRow);
            var grid = RB_DataGridView;
            grid.Sort(grid.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
        }
        private string RBGridRequest()
        {
            int code = dataBase.ParseInt(CodeFilterBox.Text);
            string name = dataBase.ParseString(NameFilterBox.Text);
            string dis = dataBase.ParseString(DisciplineFilterBox.Text);
            string Request = @"SELECT RB_Code, RB.Name, ISNULL(S.Name, '') AS SpecialtyName
                                FROM RecordBook AS RB LEFT JOIN Specialty AS S ON FK_Specialty = S_Code ";
            List<string> args = new List<string>();
            if (code != -1 || name != "" || dis != "")
            {
                args.Add("WHERE ");
                if (code != -1)
                {
                    args.Add($"RB_Code = '{code}'");
                }
                if (name != "")
                {
                    if (args.Count() > 1)
                        args.Add(" AND ");
                    args.Add(string.Format("RB.Name LIKE '%{0}%'", name));
                }
                if (dis != "")
                {
                    if (args.Count() > 1)
                        args.Add(" AND ");
                    args.Add(string.Format("S.Name LIKE '%{0}%'", dis));
                }
            }
            args.Add(" ORDER BY RB.Name");
            Request += String.Concat(args);
            return Request;
        }
        private void RBReadRow(DataGridView grid, IDataRecord record)
        {
            grid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
        }

        public void GridUpdate(string table_name)
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
                case "RecordBook":
                    RBGridInit();
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
            value = dataBase.ParseString(value);
            var request = $"UPDATE {table} " +
                            $"SET {property} = '{value}' " +
                            $"WHERE {id_name} = {id};";

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
        private void DeleteObject(string table, string id_name, int id)
        {
            var request = $"DELETE FROM {table} " +
                            $"WHERE {id_name} = {id}";

            SqlCommand Command = new SqlCommand(request, dataBase.getConnection());
            dataBase.openConnection();
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception ex) { }

        }
        private void RB_DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridView grid = RB_DataGridView;

            var row = grid.Rows[e.RowIndex];
            var id_raw = row.Cells[0].Value;
            var id = -1;
            if (id_raw != null)
                id = Convert.ToInt32(id_raw);

            RB_Form New_RB_Form = new RB_Form(id, this);
            New_RB_Form.Show();
            GridUpdate("RecordBook");
        }

        private void NameFilterBox_TextChanged(object sender, EventArgs e)
        {
            RBGridInit();
        }

        private void CodeFilterBox_TextChanged(object sender, EventArgs e)
        {
            RBGridInit();

        }

        private void DisciplineFilterBox_TextChanged(object sender, EventArgs e)
        {
            RBGridInit();
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
                        //ReportDataGridView.Columns.Add("SpecialtyName", "Направление подготовки");
                        ReportDataGridView.Columns.Add("DisciplineName", "Дисциплина");
                        ReportDataGridView.Columns.Add("MarkName", "Оценка");
                        break;
                    }
                case 2:
                    {
                        ReportDataGridView.Columns.Clear();
                        ReportDataGridView.Columns.Add("RB_Code", "Зачётная книга");
                        ReportDataGridView.Columns.Add("RB_Name", "ФИО");
                        ReportDataGridView.Columns.Add("Passed", "Экзаменов сдано");
                        ReportDataGridView.Columns.Add("Average", "Средний балл");
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
                        dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
                        break;
                    }
                case 2:
                    {
                        dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetDouble(3));
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
	                        --ISNULL(S.Name, '') AS SpecialityName,
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
                case 2:
                    {
                        Request = $@"
                                    SELECT 
	                                    RB.RB_Code as RB_Code,
	                                    RB.Name as RB_Name, 
	                                    COUNT(L.L_Code) as Passed,
	                                    ROUND(ISNULL((6-AVG(CAST(L2.FK_Mark as Float))), 0), 2) as Average
                                    FROM RecordBook as RB LEFT JOIN Line AS L ON
	                                    RB_Code = L.FK_RecordBook
	                                    LEFT JOIN Line AS L2 ON
	                                    RB_Code = L2.FK_RecordBook AND
	                                    L2.FK_Mark <= 3
                                    WHERE RB.Name LIKE '%%'
                                    GROUP BY RB.RB_Code, RB.Name
                                    ORDER BY RB.Name;
                                    ";
                        break;
                        
                    }
            }

            if ((SFilterBox.Text != "" || DFilterBox.Text != "" || MFilterBox.Text != "") && id != 2)
            {
                bool Flag = false;
                Request = string.Format("{0} WHERE", Request);

                if (SFilterBox.Text != "")
                {
                    if (Flag)
                    {
                        Request = string.Format("{0} AND", Request);
                    }
                    Request = string.Format("{0} S.Name LIKE '%{1}%'", Request, dataBase.ParseString(SFilterBox.Text));
                    Flag = true;
                }
                if (DFilterBox.Text != "")
                {
                    if (Flag)
                    {
                        Request = string.Format("{0} AND", Request);
                    }
                    Request = string.Format("{0} D.Name LIKE '%{1}%'", Request, dataBase.ParseString(DFilterBox.Text));
                    Flag = true;
                }
                if (MFilterBox.Text != "")
                {
                    if (Flag)
                    {
                        Request = string.Format("{0} AND", Request);
                    }
                    Request = string.Format("{0} M.Name LIKE '%{1}%'", Request, dataBase.ParseString(MFilterBox.Text));
                    Flag = true;
                }
            }
            switch (id)
            {
                case 0:
                    Request = string.Format(@"{0} ORDER BY RB.Name", Request);
                    break;
                case 1:
                    {
                        Request = string.Format(@"{0}
                                                GROUP BY
                                                    --S.Name,
                                                    D.Name,
                                                    M.Name
                                                ORDER BY D.Name", Request);
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

            ProfessorSelectForm selectForm = new ProfessorSelectForm();
            int prof_id;
            string prof_name;
            (prof_id, prof_name) = selectForm.GetProf(this);

            if (prof_id <= 0 || prof_name == "")
                return;

            var row = grid.Rows[e.RowIndex];
            row.Cells[2].Value = prof_name;
            row.Cells[3].Value = prof_id;

            var id = row.Cells[0].Value;
            if (id == null)
                CreateDis(row);
            else
            {
                UpdateObject("Discipline", "D_Code", (int)id, "FK_Professor", prof_id.ToString());
                GridUpdate(grid, DisGridRequest(), DisReadRow);
            }
        }

        private void CreateDis(DataGridViewRow row)
        {
            if (row.Cells[1].Value is null)
                return;
            var name = dataBase.ParseString(Convert.ToString(row.Cells[1].Value));

            if (row.Cells[3].Value is null)
                return;
            var prof_id = dataBase.ParseInt(Convert.ToString(row.Cells[3].Value));

            if (prof_id <= 0)
                return;

            var property = new List<string> { "Name", "FK_Professor" };
            var value = new List<string> { name, prof_id.ToString() };

            dataBase.InsertObject("Discipline", property, value);
            GridUpdate("Discipline");
        }

        private void DisdataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != 1)
                return;
            DataGridView grid = DisdataGridView;

            var row = grid.Rows[e.RowIndex];
            var id = row.Cells[0].Value;
            if (id == null)
                CreateDis(row);
            else
                OnCellChange(DisdataGridView, "Discipline", e);
        }

        private void DisdataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            OnRowDeletion(DisdataGridView, "Discipline", e);
        }

        private void RB_DataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

            OnRowDeletion(RB_DataGridView, "RecordBook", e);
        }

        private void MainControl_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPageIndex)
            {

                case 0:
                    RBGridInit();
                    break;
                case 1:
                    SpGridInit();
                    break;
                case 2:
                    DisGridInit();
                    break;
                case 3:
                    ProfGridInit();
                    break;
                case 4:
                    MarkGridInit();
                    break;
            }
        }
    }
}