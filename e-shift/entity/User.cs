using e_shift.dto;
using e_shift.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.entity
{
    internal class User
    {

        private int _uid;  
        private String _username;
        private String _password;
        private Role _role;

        public User(int uid, string username, string password, Role role)
        {
            _uid = uid;
            _username = username;
            _password = password;
            _role = role;
        }

        public User(int uid, string username, Role role)
        {
            _uid = uid;
            _username = username;
            _role = role;
        }



        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public int Uid { get => _uid; set => _uid = value; }
        internal Role Role { get => _role; set => _role = value; }
    }
}
