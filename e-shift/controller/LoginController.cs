using e_shift.bo.custom.impl;
using e_shift.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.controller
{
    internal class LoginController
    {

        public UserDto LoginUser(UserDto userDto) {
            return new LoginBoImpl().Login(userDto);
          
        }

        public String getCustomerId() { 
            return new CustomerBoImpl().GetCustomerId();
        }
    }
}
