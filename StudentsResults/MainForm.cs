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
        }

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
            string Request = @"SELECT D_Code, D.Name, ISNULL(P.Name, '') as ProfessorName
                               FROM Discipline AS D LEFT JOIN Professor AS P ON
                               FK_Professor = P_Code";
            return Request;
        }
        private void DisReadRow(DataGridView grid, IDataRecord record)
        {
            grid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
        }

        private void SpGridInit()
        {
            DataGridView grid = SpdataGridView;
            grid.Columns.Add("S_Code", "Код");
            grid.Columns.Add("Name", "Название");
            GridUpdate(grid, SpGridRequest(), SpReadRow);
        }

        private string SpGridRequest()
        {
            string Request = @"SELECT S_Code, Name from Specialty;";
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
    }
}