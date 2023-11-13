using Microsoft.Data.SqlClient;
using System.Data;

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
            RB_DataGridView.Columns.Add("SpecialtyName", "Направление подготовки");
            RB_DataGridView.Columns.Add("State", String.Empty);

        }

        private void ReadRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
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
    }
}