using e_shift.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.bo.custom
{
    internal interface CustomerBo : SuperBo
    {
        Boolean addCustomer(CustomerDto customer);
        String GetCustomerId();
    }
}
