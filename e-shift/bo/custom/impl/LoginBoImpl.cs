using e_shift.dao.custom.impl;
using e_shift.dto;
using e_shift.entity;
using e_shift.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.dao.custom;

namespace e_shift.bo.custom.impl
{
    internal class LoginBoImpl : LoginBo
    {

        private IUserDao dao = new UserDaoImpl();
        public UserDto Login(UserDto userDto, bool isAdmin)
        {
            //check if an user exist with the username
            bool ifUserNameExist = dao.CheckWithUserName(userDto.Username);

            Assert.IsTrue(ifUserNameExist, "No user exist with the username " + userDto.Username);

            //chech if username and password if correct

            User? user = dao.CheckWithUserNameAndPass(userDto.Username, userDto.Password);

            Assert.IsNull(user, "Invalid credentials for the user "+userDto.Username);

            //customer logged in with wrong user type
            if (isAdmin && user.Role.Equals(Role.CUSTOMER)){

                throw new InvalidDataException("User logged in with wrong type");
            }


            return UserDto.Builder().WithUserName(user.Username).WithRole(user.Role).WithUid(user.Uid).Build();
        }

        public bool UpdatePassword(string userName, string pass)
        {
            //check if an user exist with the username
            bool ifUserNameExist = dao.CheckWithUserName(userName);

            Assert.IsTrue(ifUserNameExist, "No user exist with the username " + userName);

            return dao.UpdateUserPasswordByUserName(userName, pass);
        }
    }
}
