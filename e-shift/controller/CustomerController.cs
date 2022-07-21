using e_shift.bo.custom;
using e_shift.bo.custom.impl;
using e_shift.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.controller
{
    internal class CustomerController
    {
        
        public bool SaveCustomer(CustomerDto customer) {
            return new CustomerBoImpl().AddCustomer(customer);
        }

        public bool UpdateCustomer(CustomerDto customer, string id)
        {
            return new CustomerBoImpl().UpdateCustomer(customer,id);
        }

        public bool DeleteCustomer(string id)
        {
            return new CustomerBoImpl().DeleteCustomer(id);
        }

        public DataTable GetAllCustomers()
        {
            return new CustomerBoImpl().GetAllCustomers();
        }

        public string GetCustId()
        {
            return new CustomerBoImpl().GetCustomerId();
        }

        public DataTable SearchCustomers(string atr, string search)
        {
            return new CustomerBoImpl().SearchCustomers(atr,search);
        }
        
        public CustomerDto findCustomerByUserId(int uuid)
        {
            return new CustomerBoImpl().findByUserId(uuid);
        }

        public UserDto fetchUserByCustomerId(String custID)
        {
            return new CustomerBoImpl().findUserDtoByCustId(custID);
        }


    }
}
