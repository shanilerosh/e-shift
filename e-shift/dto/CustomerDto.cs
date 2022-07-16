using e_shift.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dto
{
    internal class CustomerDto
    {
        private String _firstName;
        private String _lastName;
        private String _nic;
        private String _address;
        private String _contactNumber;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Nic { get => _nic; set => _nic = value; }
        public string Address { get => _address; set => _address = value; }
        public string ContactNumber { get => _contactNumber; set => _contactNumber = value; }




        //fluent builder
        public static CustomerDto Builder() { 
            return new CustomerDto();
        }

        public CustomerDto WithFirstName(string name) {
            Assert.HasText(name, "First Name cannot be empty");
          this.FirstName = name;
            return this;
        }

        public CustomerDto WithLastName(string name)
        {
            Assert.HasText(name, "Last Name cannot be empty");
            this.LastName = name;
            return this;
        }

        public CustomerDto WithNic(string name)
        {
            Assert.HasText(name, "NIC cannot be empty");
            this.Nic = name;
            return this;
        }

        public CustomerDto WithAddress(string name)
        {
            Assert.HasText(name, "Address cannot be empty");
            this.Address = name;
            return this;
        }

        public CustomerDto WithContactNumber(string name)
        {
            Assert.HasText(name, "Contact number cannot be empty");
            this.ContactNumber = name;
            return this;
        }

        public CustomerDto Build() { 
            return this;
        }



    }
}
