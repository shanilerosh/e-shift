using e_shift.dao.custom;
using e_shift.dao.custom.impl;
using e_shift.dto;
using e_shift.entity;
using e_shift.utility;
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
        private IUserDao userDao = new UserDaoImpl();
        public bool AddCustomer(CustomerDto customerDto)
        {
            //check username is duplicated
            bool isExist = userDao.CheckWithUserName(customerDto.UserName);

            Assert.IsFalse(isExist, "User with the username " + customerDto.UserName + " already exist. Please try again with a new username");

            var userEntity = new User(customerDto.UserName, customerDto.Password, Role.CUSTOMER);
            var customerEntity = new Customer(GetCustomerId(), customerDto.FirstName, customerDto.LastName,
                customerDto.Nic, customerDto.Address, customerDto.ContactNumber);

            //Transactional --> create new Customer and user
            return dao.CreateUserAndCustomerTransaction(customerEntity, userEntity);

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

        public CustomerDto findByUserId(int userId)
        {
            //find the customer entity
            var customer = dao.findByUserId(userId);

            if (null == customer)
            {
                throw new InvalidDataException("Customer Not Found with the id "+customer.Uid);
            }
            
            //convert customer entity to dto
            return CustomerDto.Builder().WithFirstName(customer.FirstName)
                .WithCId(customer.Cid).Build();
        }
    }
}
