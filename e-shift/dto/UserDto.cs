using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dto
{
    internal class UserDto
    {
        private String username;
        private String password;

        public UserDto(string username, string password)
        {
            this.username = username ?? throw new ArgumentNullException(nameof(username));
            this.password = password ?? throw new ArgumentNullException(nameof(password));
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
