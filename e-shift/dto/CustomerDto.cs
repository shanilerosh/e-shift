using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dto
{
    internal class CustomerDto
    {
        private String firstName;
        private String lastName;
        private String nic;
        private String address;

       
        public CustomerDto(string firstName, string lastName, string nic, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.nic = nic;
            this.address = address;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Nic { get => nic; set => nic = value; }
        public string Address { get => address; set => address = value; }
    }
}
