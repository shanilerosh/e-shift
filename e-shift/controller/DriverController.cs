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
    internal class DriverController
    {
        private IDriverBo _bo = new DriverBoImpl();
        
        public List<DriverDto> fetchDrivers()
        {
            return _bo.FetchDrivers();
        }

    }
}
