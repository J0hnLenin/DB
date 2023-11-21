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
        //SqlConnection sqlConnection = new SqlConnection(@"Server=localhost;Database=Study_results;Trusted_Connection=True;TrustServerCertificate=True");
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

        public string ParseString(string s)
        {
            return s.Replace("'", "''");
        }
        public int ParseInt(string s)
        {
            if (s == "")
                return -1;
            try
            {
                return (int)Convert.ToUInt32(s);
            }
            catch
            {
                return 0;
            }
        }

        public void InsertObject(string table, List<string> property, List<string> value)
        {
            var value_parsed = new List<string>();
            foreach (var item in value)
                value_parsed.Add(ParseString(item));

            var all_propery = String.Join(", ", property);
            var all_value = String.Join("', '", value_parsed);

            var request = $"INSERT INTO {table} ({all_propery}) " +
                            $"VALUES ('{all_value}')";

            SqlCommand Command = new SqlCommand(request, getConnection());
            openConnection();
            Command.ExecuteNonQuery();
        }
    }
}
