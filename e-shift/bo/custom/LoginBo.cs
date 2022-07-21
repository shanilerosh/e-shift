using e_shift.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.bo.custom
{
    internal interface LoginBo
    {
        UserDto Login(UserDto userDto, bool isAdmin);
        bool UpdatePassword(string userName, string pass);
    }
}
