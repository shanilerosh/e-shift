using e_shift.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.utility;

namespace e_shift.bo.custom
{
    internal interface ICustomerBo : ISuperBo
    {
        Boolean AddCustomer(CustomerDto customer);

        bool UpdateCustomer(CustomerDto customer, string custId);

        bool DeleteCustomer(string custId);

        DataTable GetAllCustomers();

        DataTable SearchCustomers(string atr, string search);

        String GetCustomerId();

        CustomerDto FindByUserId(int userId);

        UserDto FindUserDtoByCustId(string custId);
        DataTable FetchCustomerByStatus(CustomerStatus status);
        bool UpdateCustomerStatus(CustomerStatus status, string text);
    }
}
