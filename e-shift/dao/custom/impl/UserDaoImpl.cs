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
    internal class UserDaoImpl : IUserDao
    {

        public bool Add(User entity)
        {

            /*  try
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
              }*/
            return true;
        }

        public bool CheckWithUserName(string userName)
        {
            var keyValPair = new Dictionary<string, object>();

            keyValPair.Add("username", userName);

            try
            {
                SqlDataReader sqlDataReader = CrudUtil.ExecuteSelectQuery("SELECT TOP 1 uid from db.userdata WHERE username = @username", keyValPair);

                return sqlDataReader.HasRows;
            }
            finally
            {
                DbConnection.GetInstance().GetConnection().Close();
            }

        }

        public User? CheckWithUserNameAndPass(string username, string password)
        {
            try
            {
                var keyValPair = new Dictionary<string, object>();

                keyValPair.Add("username", username);
                keyValPair.Add("password", password);

                SqlDataReader reader = CrudUtil.ExecuteSelectQuery("SELECT * from db.userdata WHERE username = @username AND password = @password", keyValPair);

            
                if (reader.HasRows) {
                    while (reader.Read()) {
                        Role role = (Role) Enum.Parse(typeof(Role), reader.GetString(3));
                        return new User(reader.GetInt32(0), reader.GetString(1),role);
                    }
            
                }
            }
            finally
            {
                DbConnection.GetInstance().GetConnection().Close();
            }
            
            
            return null;
        }


        public User? CheckWithUserNameAndGetUserObj(string username)
        {
            try
            {
                var keyValPair = new Dictionary<string, object>();

                keyValPair.Add("username", username);

                SqlDataReader reader = CrudUtil.ExecuteSelectQuery("SELECT * from db.userdata WHERE username = @username", keyValPair);


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Role role = (Role)Enum.Parse(typeof(Role), reader.GetString(3));
                        return new User(reader.GetInt32(0), reader.GetString(1), role);
                    }

                }
            }
            finally
            {
                DbConnection.GetInstance().GetConnection().Close();
            }
            
            return null;
        }

        public bool CreateNewUser(User user)
        {
            var keyValPair = new Dictionary<string, object>();

            keyValPair.Add("@username", user.Username);
            keyValPair.Add("@password", user.Password);
            keyValPair.Add("@role", user.Role.ToString());
            


            return CrudUtil.ExecuteUpdateDelete("INSERT INTO db.userdata(username,password,role) VALUES (@username,@password,@role)",
                keyValPair);
        }

        public bool Delete(string id)
        {
         /*   var keyValPair = new Dictionary<string, object>();

            //adding cid for the where clause
            keyValPair.Add("@cid", id);

            return CrudUtil.ExecuteUpdateDelete("DELETE FROM db.customer WHERE cid = @cid",
                keyValPair);*/

            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            return CrudUtil.ExecuteSelectQueryForDataGrid("SELECT * FROM db.customer");
        }


     

        public DataTable SearchUser(string fields, string val)
        {

            return CrudUtil.ExecuteSelectQueryForDataGrid("SELECT * FROM db.customer WHERE "+ fields + " LIKE '%" +val+ "%'");
            

        }

        public bool Update(User entity)
        {
            var keyValPair = new Dictionary<string, object>();

            /*keyValPair.Add("@firstName", entity.FirstName);
            keyValPair.Add("@lastName", entity.LastName);
            keyValPair.Add("@nic", entity.Nic);
            keyValPair.Add("@address", entity.Address);
            keyValPair.Add("@contactNumber", entity.ContactNumber);
            keyValPair.Add("@cid", entity.Cid);*/

            return CrudUtil
                .ExecuteUpdateDelete("UPDATE db.customer SET firstname = @firstName ,lastname = @lastname ,nic = @nic ,address = @address, contactnumber = @contactnumber WHERE cid = @cid",
                keyValPair);
        }
    }
}
