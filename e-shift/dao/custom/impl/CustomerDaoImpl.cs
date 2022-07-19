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
        //Transaction Event Where two tables get effected
        public bool Add(Customer customer)
        {
            return true;

            
        }

        public bool CreateUserAndCustomerTransaction(Customer customer, User user)
        {

            /*Get the singleton connection*/
            var conn = DbConnection.GetInstance().GetConnection();

            conn.Open();
            //begin transaction
            var transaction = conn.BeginTransaction();

            try
            {
                //create the user first
                var userCommand = new
                    SqlCommand("INSERT INTO db.userdata(username,password,role) VALUES (@username,@password,@role); SELECT SCOPE_IDENTITY()", conn, transaction);
                userCommand.Parameters.AddWithValue("@username", user.Username);
                userCommand.Parameters.AddWithValue("@password", user.Password);
                userCommand.Parameters.AddWithValue("@role", user.Role.ToString());

                object userId = userCommand.ExecuteScalar();

                //create the customer entry
                var custCommand = new
                    SqlCommand("INSERT INTO db.customer(cid,firstname,lastname,nic,address,contactNumber,uid) Values (@cid,@firstName,@lastName,@nic,@address,@contactNumber,@uid)", conn, transaction);

                custCommand.Parameters.AddWithValue("@cid", customer.Cid);
                custCommand.Parameters.AddWithValue("@firstName", customer.FirstName);
                custCommand.Parameters.AddWithValue("@lastName", customer.LastName);
                custCommand.Parameters.AddWithValue("@nic", customer.Nic);
                custCommand.Parameters.AddWithValue("@address", customer.Address);
                custCommand.Parameters.AddWithValue("@contactNumber", customer.ContactNumber);
                custCommand.Parameters.AddWithValue("@uid", userId);

                var isDone = custCommand.ExecuteNonQuery();
                //if success commit transaction
                transaction.Commit();
                return isDone > 0;

            }
            catch (Exception e)
            {
                //if an excemption occured rollback to the original state
                transaction.Rollback();
                throw;
            }
            finally {
                conn.Close();
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

        public Customer findByCustId(string custId)
        {
            try
            {
                using (SqlDataReader sqlDataReader = CrudUtil
                   .ExecuteSelectQuery("SELECT TOP 1 * FROM db.customer WHERE cid = '"+custId+"'"))
                {
                    //.ExecuteSelectQuery("SELECT * FROM db.customer")) {
                    if (sqlDataReader.HasRows)
                    {

                        while (sqlDataReader.Read())
                        {
                            
                            return new Customer(sqlDataReader.GetString(0),
                                sqlDataReader.GetString(1), sqlDataReader.GetString(2),
                                sqlDataReader.GetString(3), sqlDataReader.GetString(4),
                                sqlDataReader.GetString(5));
                            
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
