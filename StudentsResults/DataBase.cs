using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace StudentsResults
{
    internal class DataBase
    {
        //SqlConnection sqlConnection = new SqlConnection(@"JOHN_LENIN");
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=JOHN_LENIN;Initial Catalog=Study_results;Integrated Security=True;TrustServerCertificate=True");
        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
