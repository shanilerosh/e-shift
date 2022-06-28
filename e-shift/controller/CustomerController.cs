using e_shift.bo.custom;
using e_shift.bo.custom.impl;
using e_shift.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.controller
{
    internal class CustomerController
    {
        

        public bool SaveCustomer(CustomerDto customer) {
            return new CustomerBoImpl().addCustomer(customer);
        }
    }
}
