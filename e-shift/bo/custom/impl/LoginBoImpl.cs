using e_shift.dao.custom.impl;
using e_shift.dto;
using e_shift.entity;
using e_shift.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.bo.custom.impl
{
    internal class LoginBoImpl : LoginBo
    {
        public UserDto Login(UserDto userDto)
        {
            //check if an user exist with the username
            bool ifUserNameExist = new UserDaoImpl().CheckWithUserName(userDto.Username);

            Assert.IsTrue(ifUserNameExist, "No user exist with the username " + userDto.Username);

            //chech if username and password if correct

            User? user = new UserDaoImpl().CheckWithUserNameAndPass(userDto.Username, userDto.Password);

            Assert.IsNull(user, "Invalid credentials for the user "+userDto.Username);


            return UserDto.Builder().WithUserName(user.Username).WithRole(user.Role).WithUid(userDto.Uid).Build();
        }
    }
}
