using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
    }
}