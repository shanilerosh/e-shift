using e_shift.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.bo.custom
{
    internal interface ITransportUnitBo : ISuperBo
    {
        Boolean AddTransportUnit(TransportUnitDto transportUnitDto);

        bool UpdateTransportUnit(TransportUnitDto transportUnitDto, string tsId);

        bool DeleteTransportUnit(string tsId);

        DataTable GetAllTransportUnits();

        DataTable SearchTransportUnits(string atr, string search);

        String GetTransportUnitId();
    }
}
