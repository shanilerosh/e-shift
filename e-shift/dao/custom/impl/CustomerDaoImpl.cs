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

            try
            {
                var keyValPair = new Dictionary<string, object>();

                keyValPair.Add("@cid", entity.Cid);
                keyValPair.Add("@firstName", entity.FirstName);
                keyValPair.Add("@lastName", entity.LastName);
                keyValPair.Add("@nic", entity.Nic);
                keyValPair.Add("@address", entity.Address);
                keyValPair.Add("@contactNumber", entity.ContactNumber);
                

                return CrudUtil.ExecuteUpdateDelete("INSERT INTO db.customer(cid,firstname,lastname,nic,address,contactnumber) Values (@cid,@firstName,@lastName,@nic,@address,@contactNumber)",
                    keyValPair);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(string id)
        {
            var keyValPair = new Dictionary<string, object>();

            //adding cid for the where clause
            keyValPair.Add("@cid", id);

            return CrudUtil.ExecuteUpdateDelete("DELETE FROM db.customer WHERE cid = @cid",
                keyValPair);
        }

        public DataTable GetAll()
        {
            return CrudUtil.ExecuteSelectQueryForDataGrid("SELECT * FROM db.customer");
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

        public DataTable SearchCustomers(string fields, string val)
        {

            return CrudUtil.ExecuteSelectQueryForDataGrid("SELECT * FROM db.customer WHERE "+ fields + " LIKE '%" +val+ "%'");
            

        }

        public bool Update(Customer entity)
        {
            var keyValPair = new Dictionary<string, object>();

            keyValPair.Add("@firstName", entity.FirstName);
            keyValPair.Add("@lastName", entity.LastName);
            keyValPair.Add("@nic", entity.Nic);
            keyValPair.Add("@address", entity.Address);
            keyValPair.Add("@contactNumber", entity.ContactNumber);
            keyValPair.Add("@cid", entity.Cid);

            return CrudUtil
                .ExecuteUpdateDelete("UPDATE db.customer SET firstname = @firstName ,lastname = @lastname ,nic = @nic ,address = @address, contactnumber = @contactnumber WHERE cid = @cid",
                keyValPair);
        }
    }
}
