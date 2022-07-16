using e_shift.dao.custom;
using e_shift.dao.custom.impl;
using e_shift.dto;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.bo.custom.impl
{
    internal class TransportUnitBoImpl : ITransportUnitBo
    {

        private ITransportUnitDao dao = new TransportUnitDaoIml();
        public bool AddTransportUnit(TransportUnitDto dto)
        {
            return dao
                .Add(new TransportUnit(this.GetTransportUnitId(), dto.VehicleType, dto.VehicleNo, dto.Model, dto.Capacity, dto.Remark));

        }

        public bool UpdateTransportUnit(TransportUnitDto dto, string tid)
        {
            return dao
                .Update(new TransportUnit(tid, dto.VehicleType, dto.VehicleNo, dto.Model, dto.Capacity, dto.Remark));

        }

        public bool DeleteTransportUnit(string tid)
        {
            return dao
                .Delete(tid);
        }

        public DataTable GetAllTransportUnits() {

            return dao
                .GetAll();
        }

        public DataTable SearchTransportUnits(string atr, string search)
        {

            return dao.SearchTransportUnit(atr, search);
        }

        public string GetTransportUnitId()
        {
            String transportUnitId = dao.GetTransportUnitId();
            if (transportUnitId != null)
            {
                String[] temp = transportUnitId.Split("T");
                int tempNumber = int.Parse(temp[1]);
                tempNumber++;

                if (tempNumber < 10)
                {
                    transportUnitId = "T00" + tempNumber;
                }
                else if (tempNumber < 100)
                {
                    transportUnitId = "T0" + tempNumber;
                }
                else
                {
                    transportUnitId = "T" + tempNumber;
                }
            }
            else
            {
                transportUnitId = "T001";
            }

            return transportUnitId;
        }

        
    }
}
