using System.Data.SqlClient;

namespace MasterMind.Database
{
    class DatabaseConnection
    {
        private static readonly DatabaseConnection Instance = new DatabaseConnection();
        private static readonly SqlConnection Connection = 
            new SqlConnection(@"Data Source=DESKTOP-SKTSU8H\SQLEXPRESS;" + "Initial Catalog=Mastermind;Integrated Security=SSPI;");

        private DatabaseConnection(){}

        public static DatabaseConnection GetInstance => Instance;

        public SqlConnection GetDatabaseConnection => Connection;
    }
}
