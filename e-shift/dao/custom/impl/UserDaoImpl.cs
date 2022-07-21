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
                SqlDataReader sqlDataReader = CrudUtil.ExecuteSelectQuery("SELECT TOP 1 uid from userdata WHERE username = @username", keyValPair);

                return sqlDataReader.HasRows;
            }
            finally
            {
                DbConnection.GetInstance().GetConnection().Close();
            }

        }

        public User? CheckWithUserNameAndPass(string username)
        {
            try
            {
                var keyValPair = new Dictionary<string, object>();

                keyValPair.Add("username", username);

                SqlDataReader reader = CrudUtil.ExecuteSelectQuery("SELECT * from userdata WHERE username = @username", keyValPair);

            
                if (reader.HasRows) {
                    while (reader.Read()) {
                        Role role = (Role) Enum.Parse(typeof(Role), reader.GetString(3));
                        return new User(reader.GetInt32(0), reader.GetString(1),reader.GetString(2),
                            role);
                    }
            
                }
            }
            finally
            {
                DbConnection.GetInstance().GetConnection().Close();
            }
            
            
            return null;
        }
        
        

        public User findByUserId(int userId)
        {
            {
                try
                {
                    using (var sqlDataReader = CrudUtil
                               .ExecuteSelectQuery("SELECT TOP 1 * FROM userdata WHERE uid = '" + userId + "'"))
                    {
                        //.ExecuteSelectQuery("SELECT * FROM customer")) {
                        if (sqlDataReader.HasRows)
                        {

                            while (sqlDataReader.Read())
                            {

                                Role role = (Role)Enum.Parse(typeof(Role), sqlDataReader.GetString(3));
                                return new User(sqlDataReader.GetInt32(0),
                                    sqlDataReader.GetString(1), role);

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
        }

        public bool UpdateUserPasswordByUserName(string userName, string pass)
        {
            var keyValPair = new Dictionary<string, object>();

            keyValPair.Add("@password", pass);
            keyValPair.Add("@username", userName);
            
            return CrudUtil
                .ExecuteUpdateDelete("UPDATE userdata SET password = @password WHERE username = @username",
                    keyValPair);
        }


        public User? CheckWithUserNameAndGetUserObj(string username)
        {
            try
            {
                var keyValPair = new Dictionary<string, object>();

                keyValPair.Add("username", username);

                SqlDataReader reader = CrudUtil.ExecuteSelectQuery("SELECT * from userdata WHERE username = @username", keyValPair);


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
            


            return CrudUtil.ExecuteUpdateDelete("INSERT INTO userdata(username,password,role) VALUES (@username,@password,@role)",
                keyValPair);
        }
        
      
    }
}
