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
    internal class TransportUnitController
    {
        
        public bool SaveTransportUnit(TransportUnitDto transportUnitDto) {
            return new TransportUnitBoImpl().AddTransportUnit(transportUnitDto);
        }

        public bool UpdateTransportUnit(TransportUnitDto transportUnitDto, string id)
        {
            return new TransportUnitBoImpl().UpdateTransportUnit(transportUnitDto, id);
        }

        public bool DeleteTransportUnit(string id)
        {
            return new TransportUnitBoImpl().DeleteTransportUnit(id);
        }

        public DataTable GetAllTransportUnits()
        {
            return new TransportUnitBoImpl().GetAllTransportUnits();
        }

        public string GetTransportUnitId()
        {
            return new TransportUnitBoImpl().GetTransportUnitId();
        }

        public DataTable SearchTransportUnits(string atr, string search)
        {
            return new TransportUnitBoImpl().SearchTransportUnits(atr, search); 
        }


    }
}
