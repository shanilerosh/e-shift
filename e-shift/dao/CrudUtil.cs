using e_shift.db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dao
{
    internal class CrudUtil
    {
        private static SqlCommand SetSqlCommand(String sql, IDictionary<String, object> param) {

            /*Get the singleton connection*/
            SqlConnection conn = DbConnection.GetInstance().GetConnection();

            using SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();

            /*Iterate through key value pair and append in to the sql command*/
            foreach (var val in param)
            {
                String attribute = val.Key;
                object value = val.Value;

                cmd.Parameters.AddWithValue(attribute, value);
            }
            return cmd;

        }

        public static bool ExecuteUpdateDelete(String sql, IDictionary<String, object> param) {
            bool result = SetSqlCommand(sql, param).ExecuteNonQuery() > 0;

            //close the connection of the connection object
            DbConnection.GetInstance().GetConnection().Close();

            return result;
        }

        public static SqlDataReader ExecuteSelectQuery(String sql, IDictionary<String, object> param)
        {
            return SetSqlCommand(sql, param).ExecuteReader();

        }

        public static SqlDataReader ExecuteSelectQuery(String sql)
        {
            //initialize an empty directory as no params are parsed 
            var emptyDirectory = new Dictionary<String, object>();

            var result = SetSqlCommand(sql, emptyDirectory).ExecuteReader();

            //close the connection of the connection object
            
            return result;
        }

        public static DataTable ExecuteSelectQueryForDataGrid(String sql)
        {
            //get the connection
            var conn = DbConnection.GetInstance().GetConnection();

            //initailize adaptr obj
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);

            DataTable data = new DataTable();

            //fill dataTable with adapter
            sda.Fill(data);

            conn.Close();

            return data;

        }
    }
}
