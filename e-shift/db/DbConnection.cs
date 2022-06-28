using System.Data.SqlClient;

namespace e_shift.db
{
    /*Singleton class to get the
        db connection instance*/
    internal class DbConnection
    {
        private static DbConnection dbConnection;
        private SqlConnection connection;

        public DbConnection()
        {
            String connectionString = @"Data Source=localhost;Initial Catalog=e-shift;User ID=sa;Password=Wangedigala@123";
            connection = new SqlConnection(connectionString);
        }

        public static DbConnection GetInstance()
        {
            return (dbConnection == null) ? (dbConnection = new DbConnection()) : dbConnection;
        }

        public SqlConnection GetConnection() {
            return connection;
        }
    }
}