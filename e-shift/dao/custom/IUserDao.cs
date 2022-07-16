using e_shift.dto;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dao.custom
{
    internal interface IUserDao : CrudDao<User, int>
    {

        DataTable SearchUser(string field, string val);


        bool CheckWithUserName(string userName);    

        User CheckWithUserNameAndPass(string userName, string password);

        bool CreateNewUser(User user);

        User CheckWithUserNameAndGetUserObj(string username);
    }
}
