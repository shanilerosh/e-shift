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
        
        
    }
}
