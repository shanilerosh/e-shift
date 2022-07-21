using System.Data;
using System.Data.SqlClient;
using e_shift.db;
using e_shift.entity;
using e_shift.utility;

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
                    SqlCommand("INSERT INTO userdata(username,password,role) VALUES (@username,@password,@role); SELECT SCOPE_IDENTITY()", conn, transaction);
                userCommand.Parameters.AddWithValue("@username", user.Username);
                userCommand.Parameters.AddWithValue("@password", user.Password);
                userCommand.Parameters.AddWithValue("@role", user.Role.ToString());

                object userId = userCommand.ExecuteScalar();

                //create the customer entry
                var custCommand = new
                    SqlCommand("INSERT INTO customer(cid,firstname,lastname,nic,address,contactNumber,uid,customerStatus) Values (@cid,@firstName,@lastName,@nic,@address,@contactNumber,@uid, @customerStatus)", conn, transaction);

                custCommand.Parameters.AddWithValue("@cid", customer.Cid);
                custCommand.Parameters.AddWithValue("@firstName", customer.FirstName);
                custCommand.Parameters.AddWithValue("@lastName", customer.LastName);
                custCommand.Parameters.AddWithValue("@nic", customer.Nic);
                custCommand.Parameters.AddWithValue("@address", customer.Address);
                custCommand.Parameters.AddWithValue("@contactNumber", customer.ContactNumber);
                custCommand.Parameters.AddWithValue("@uid", userId);
                custCommand.Parameters.AddWithValue("@customerStatus", customer.CustomerStatus.ToString());

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

            return CrudUtil.ExecuteUpdateDelete("DELETE FROM customer WHERE cid = @cid",
                keyValPair);
        }

        public Customer findByCustId(string custId)
        {
            try
            {
                using (SqlDataReader sqlDataReader = CrudUtil
                   .ExecuteSelectQuery("SELECT TOP 1 * FROM customer WHERE cid = '"+custId+"'"))
                {
                    //.ExecuteSelectQuery("SELECT * FROM customer")) {
                    if (sqlDataReader.HasRows)
                    {

                        while (sqlDataReader.Read())
                        {
                            
                            return new Customer(sqlDataReader.GetString(0),
                                sqlDataReader.GetString(1), sqlDataReader.GetString(2),
                                sqlDataReader.GetString(3), sqlDataReader.GetString(4),
                                sqlDataReader.GetString(5),sqlDataReader.GetInt32(6));
                            
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

        public Customer findByUserId(int userId)
        {
            try
            {
                using (SqlDataReader sqlDataReader = CrudUtil
                           .ExecuteSelectQuery("SELECT TOP 1 * FROM customer WHERE uid = '"+userId+"'"))
                {
                    //.ExecuteSelectQuery("SELECT * FROM customer")) {
                    if (sqlDataReader.HasRows)
                    {

                        while (sqlDataReader.Read())
                        {
                            var custStatus = (CustomerStatus)Enum.
                                Parse(typeof(CustomerStatus), sqlDataReader.GetString(7));
                            var customer = new Customer(sqlDataReader.GetString(0),
                                sqlDataReader.GetString(1), sqlDataReader.GetString(2),
                                sqlDataReader.GetString(3), sqlDataReader.GetString(4),
                                sqlDataReader.GetString(5));
                            customer.CustomerStatus = custStatus;
                            return customer;
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

        public DataTable GetAllByStatus(CustomerStatus status)
        {
            return CrudUtil.ExecuteSelectQueryForDataGrid("SELECT cid AS [ID],firstname AS [First Name], lastname AS" +
                                                          " [Last Name], nic AS [NIC], address AS [Address],contactnumber AS [Contact Number], customerStatus as [Status] FROM " +
                                                          "customer WHERE customerStatus = '"+status+"'");
        }

        public bool UpdateCustStatus(CustomerStatus status, string cid)
        {
            var keyValPair = new Dictionary<string, object>();

            keyValPair.Add("@customerStatus", status.ToString());
            keyValPair.Add("@cid", cid);

            return CrudUtil
                .ExecuteUpdateDelete("UPDATE customer SET customerStatus = @customerStatus WHERE cid = @cid",
                    keyValPair);
        }

        public DataTable GetAll()
        {
            return CrudUtil.ExecuteSelectQueryForDataGrid("SELECT cid AS [ID],firstname AS [First Name], lastname AS" +
                                                          " [Last Name], nic AS [NIC], address AS [Address],contactnumber AS [Contact Number], customerStatus as [Status] FROM " +
                                                          "customer");
        }

        public string GetCustomerId()
        {
            try
            {
                using (SqlDataReader sqlDataReader = CrudUtil
                   .ExecuteSelectQuery("SELECT TOP 1 cid FROM customer ORDER BY cid DESC"))
                {
                    //.ExecuteSelectQuery("SELECT * FROM customer")) {
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

            return CrudUtil.ExecuteSelectQueryForDataGrid("SELECT * FROM customer WHERE "+ fields + " LIKE '%" +val+ "%'");
            

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
                .ExecuteUpdateDelete("UPDATE customer SET firstname = @firstName ,lastname = @lastname ,nic = @nic ,address = @address, contactnumber = @contactnumber WHERE cid = @cid",
                keyValPair);
        }
    }
}
