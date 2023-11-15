using Microsoft.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.LinkLabel;

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
        int SelectedRow;
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
            DataGridView grid = MarkdataGridView;
            grid.Columns.Add("M_Code", "Код");
            grid.Columns.Add("Name", "Название");
            GridUpdate(grid, MarkGridRequest(), MarkReadRow);
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
            grid.Columns.Add("Name", "Название");
            grid.Columns.Add("ProfessorName", "Профессор");
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

        //Specialty grid
        private void SpGridInit()
        {
            DataGridView grid = SpdataGridView;
            grid.Columns.Add("S_Code", "Код");
            grid.Columns.Add("Name", "Название");
            GridUpdate(grid, SpGridRequest(), SpReadRow);
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

        private void CreateColumns()
        {
            RB_DataGridView.Columns.Add("RB_Code", "Код");
            RB_DataGridView.Columns.Add("Name", "ФИО");
            RB_DataGridView.Columns.Add("SpecialtyName", "Направление\nподготовки");
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

        private void RB_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void ProfdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}