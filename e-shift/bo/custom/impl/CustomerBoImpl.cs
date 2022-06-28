using e_shift.dao.custom;
using e_shift.dao.custom.impl;
using e_shift.dto;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.bo.custom.impl
{
    internal class CustomerBoImpl : CustomerBo
    {

        private ICustomerDao dao = new CustomerDaoImpl();
        public bool addCustomer(CustomerDto customer)
        {
            return dao
                .Add(new Customer(this.GetCustomerId(), customer.FirstName, customer.LastName, customer.Nic, customer.Address));

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
