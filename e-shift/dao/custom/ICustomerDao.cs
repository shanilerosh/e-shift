using e_shift.dto;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.utility;

namespace e_shift.dao.custom
{
    internal interface ICustomerDao : CrudDao<Customer, String>
    {
        String GetCustomerId();

        DataTable SearchCustomers(string field, string val);

        bool CreateUserAndCustomerTransaction(Customer customer, User user);

        Customer findByCustId(string custId);
        Customer findByUserId(int userId);
        DataTable GetAllByStatus(CustomerStatus status);
        bool UpdateCustStatus(CustomerStatus status, string text);
    }
}
