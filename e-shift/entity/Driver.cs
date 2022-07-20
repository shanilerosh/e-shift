﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.entity
{
    public class Driver
    {

        private  int _did;
        private string _driverName;

        public int Did { get => _did; set => _did = value; }
        public string DriverName { get => _driverName; set => _driverName = value; }

        public Driver(int did, string driverName)
        {
            _did = did;
            _driverName = driverName;
        }
    }
}
