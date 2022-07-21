using e_shift.db;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.utility;

namespace e_shift.dao.custom.impl
{
    internal class DriverDaoImpl : IDriverDao
    {
        public List<Driver> fetchAllDrivers()
        {
            var listOfItems = new List<Driver>();
            try
            {
                
                using (SqlDataReader sqlDataReader = CrudUtil
                           .ExecuteSelectQuery("SELECT * FROM driver"))
                {
                    if (sqlDataReader.HasRows)
                    {

                        while (sqlDataReader.Read())
                        {
                            listOfItems.Add(new Driver(sqlDataReader.GetInt32(0),
                                sqlDataReader.GetString(1)));
                        }
                    }
                }

                return listOfItems;
            }
            finally
            {
                DbConnection.GetInstance().GetConnection().Close();
            }
        }
    }
}
