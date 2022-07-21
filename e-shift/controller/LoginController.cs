using e_shift.bo.custom.impl;
using e_shift.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.bo.custom;

namespace e_shift.controller
{
    internal class LoginController
    {

        private LoginBo _bo = new LoginBoImpl();
        
        public UserDto LoginUser(UserDto userDto, bool isAdmin) {
            return _bo.Login(userDto,isAdmin);
          
        }

        public bool UpdatePassword(string userName, string pass)
        {
            return _bo.UpdatePassword(userName, pass);
        }
    }
}
