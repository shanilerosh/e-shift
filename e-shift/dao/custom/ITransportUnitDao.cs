﻿using e_shift.dto;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dao.custom
{
    internal interface ITransportUnitDao : CrudDao<TransportUnit, String>
    {
        String GetTransportUnitId();

        DataTable SearchTransportUnit(string field, string val);
    }
}
