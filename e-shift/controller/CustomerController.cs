using e_shift.bo.custom;
using e_shift.bo.custom.impl;
using e_shift.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.utility;

namespace e_shift.controller
{
    internal class CustomerController
    {
        private ICustomerBo _bo = new CustomerBoImpl();
        
        public bool SaveCustomer(CustomerDto customer) {
            return _bo.AddCustomer(customer);
        }

        public bool UpdateCustomer(CustomerDto customer, string id)
        {
            return _bo.UpdateCustomer(customer,id);
        }

        public bool DeleteCustomer(string id)
        {
            return _bo.DeleteCustomer(id);
        }

        public DataTable GetAllCustomers()
        {
            return _bo.GetAllCustomers();
        }

        public string GetCustId()
        {
            return _bo.GetCustomerId();
        }

        public DataTable SearchCustomers(string atr, string search)
        {
            return _bo.SearchCustomers(atr,search);
        }
        
        public CustomerDto FindCustomerByUserId(int uuid)
        {
            return _bo.FindByUserId(uuid);
        }

        public UserDto FetchUserByCustomerId(String custID)
        {
            return _bo.FindUserDtoByCustId(custID);
        }

        public DataTable FetchCustomerByStatus(CustomerStatus status)
        {
            return _bo.FetchCustomerByStatus(status);
        }


        public bool UpdateCustomerStatus(CustomerStatus status, string text)
        {
            return _bo.UpdateCustomerStatus(status,text);
        }
    }
}
