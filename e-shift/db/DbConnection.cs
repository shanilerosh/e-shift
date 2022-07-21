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
            String connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\C#\e-shift\e-shift\Database2.mdf;Integrated Security=True";
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