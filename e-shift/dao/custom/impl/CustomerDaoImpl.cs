using e_shift.db;
using e_shift.dto;
using e_shift.entity;
using e_shift.utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dao.custom.impl
{
    internal class CustomerDaoImpl : ICustomerDao
    {

        public bool Add(Customer entity)
        {

            IDictionary<string, string> keyValPair =
                CommonConverter<Customer>.convertObjectToDirectory(entity);

            return CrudUtil.ExecuteUpdateDelete("INSERT INTO db.customer(cid,firstname,lastname,nic,address) Values (@cid,@firstName,@lastName,@nic,@address)",
                keyValPair);
        }

        public bool Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll(Customer entity)
        {
            throw new NotImplementedException();
        }

        public string GetCustomerId()
        {
            try
            {
                using (SqlDataReader sqlDataReader = CrudUtil
                   .ExecuteSelectQuery("SELECT TOP 1 cid FROM db.customer ORDER BY cid DESC"))
                {
                    //.ExecuteSelectQuery("SELECT * FROM db.customer")) {
                    if (sqlDataReader.HasRows)
                    {

                        while (sqlDataReader.Read())
                        {
                            return sqlDataReader.GetString(0);
                        }
                    }
                }
            }
            finally
            {
                DbConnection.GetInstance().GetConnection().Close();
            }

            return null;
        }

        public bool Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
