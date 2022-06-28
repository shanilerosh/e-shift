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

        public void loginUser(UserDto userDto) {
            MessageBox.Show("Hello World",userDto.Username);
            MessageBox.Show("Hello World",userDto.Password);
          
        }

        public String getCustomerId() { 
            return new CustomerBoImpl().GetCustomerId();
        }
    }
}
