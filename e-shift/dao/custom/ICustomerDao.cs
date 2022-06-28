using e_shift.dto;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dao.custom
{
    internal interface ICustomerDao : CrudDao<Customer, String>
    {
        String GetCustomerId();
    }
}
