﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.utility;

namespace e_shift.entity
{
    public class Customer
    {

        private String cid;
        private String firstName;
        private String lastName;
        private String nic;
        private String address;
        private String contactNumber;
        //user entity foreign constraint
        private int uid;
        private CustomerStatus _customerStatus;


       
        public Customer(string cid,string firstName, string lastName, string nic, string address, string contactNumber)
        {
            this.cid = cid;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Nic = nic;
            this.Address = address;
            this.ContactNumber = contactNumber;
        }

        public Customer(string cid, string firstName, string lastName, string nic, string address, string contactNumber, int uid) : this(cid, firstName, lastName, nic, address, contactNumber)
        {
            this.Uid = uid;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Nic { get => nic; set => nic = value; }
        public string Address { get => address; set => address = value; }
        public string Cid { get => cid; set => cid = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public int Uid { get => uid; set => uid = value; }
        public CustomerStatus CustomerStatus { get => _customerStatus; set => _customerStatus = value; }
    }
}
