using e_shift.dao.custom;
using e_shift.dao.custom.impl;
using e_shift.dto;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.bo.custom.impl
{
    internal class CustomerBoImpl : ICustomerBo
    {

        private ICustomerDao dao = new CustomerDaoImpl();
        public bool AddCustomer(CustomerDto customer)
        {
            return dao
                .Add(new Customer(this.GetCustomerId(), customer.FirstName, customer.LastName, customer.Nic, customer.Address, customer.ContactNumber));

        }

        public bool UpdateCustomer(CustomerDto customer, string custId)
        {
            return dao
                .Update(new Customer(custId, customer.FirstName, customer.LastName, customer.Nic, customer.Address, customer.ContactNumber));

        }

        public bool DeleteCustomer(string custId)
        {
            return dao
                .Delete(custId);
        }

        public DataTable GetAllCustomers() {

            return dao
                .GetAll();
        }

        public DataTable SearchCustomers(string atr, string search)
        {

            return dao.SearchCustomers(atr, search);
        }

        public string GetCustomerId()
        {
            String custId = dao.GetCustomerId();
            if (custId != null)
            {
                String[] temp = custId.Split("C");
                int tempNumber = int.Parse(temp[1]);
                tempNumber++;

                if (tempNumber < 10)
                {
                    custId = "C00" + tempNumber;
                }
                else if (tempNumber < 100)
                {
                    custId = "C0" + tempNumber;
                }
                else
                {
                    custId = "C" + tempNumber;
                }
            }
            else
            {
                custId = "C001";
            }

            return custId;
        }
    }
}
