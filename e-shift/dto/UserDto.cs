using e_shift.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dto
{
     public class UserDto
    {
        private int _uid;
        private string _username;
        private string _password;
        private Role _role;

        public UserDto(int uid, string username, Role role)
        {
            _uid = uid;
            _username = username;
            _role = role;
        }

        public UserDto()
        {
        }


        //fluent builder
        public static UserDto Builder() {
            return new UserDto();
        }

        public UserDto WithUserName(string name) {
            Assert.HasText(name, "Username cannot be empty");
            this._username = name;
            return this;
        }

        public UserDto WithUid(int id)
        {
            Assert.HasNumber(id, "Username cannot be empty");
            this._uid = id;
            return this;
        }

        public UserDto WithPassword(string name)
        {
            Assert.HasText(name, "Password cannot be empty");
            this._password = name;
            return this;
        }

        public UserDto WithRole(Role role)
        {
            Assert.IsNull(role, "Role Cannot be Empty");
            this.Role = role;
            return this;
        }


        public UserDto Build()
        {
            return this;
        }





        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        internal Role Role { get => _role; set => _role = value; }
        public int Uid { get => _uid; set => _uid = value; }
    }
}
