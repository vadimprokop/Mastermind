using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.Database
{
    class DatabaseOperations
    {
        private static readonly DatabaseConnection DatabaseConnection = DatabaseConnection.GetInstance;

        public static List<string> GetResults()
        {
            List<String> results = new List<string>();
            String queryString = "SELECT * FROM PlayersResults Order by PlayerScore DESC";
            SqlConnection sqlConnection = DatabaseConnection.GetDatabaseConnection;
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    results.Add(reader[1] + "\t\t" + reader[2]);
                }
            }
            finally
            {
                reader.Close();
            }
            sqlConnection.Close();
            return results;
        }

        public void WriteToDatabase(string nickName, int score)
        {
            String queryString = "insert into PlayersResults values (@param1, @param2)";
            SqlConnection sqlConnection = DatabaseConnection.GetDatabaseConnection;
            SqlCommand command = new SqlCommand(queryString, sqlConnection);
            sqlConnection.Open();
            command.Parameters.Add("@param1", SqlDbType.NVarChar, 50).Value = nickName;
            command.Parameters.Add("@param2", SqlDbType.Int).Value = score;
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}