using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.entity
{
    internal class TransportUnit
    {

        private String _tpId;
        private String _vehicleType;
        private String _vehicleNo;
        private String _model;
        private int _capacity;
        private String _remark;

        public TransportUnit(string tpId, string vehicleType, string vehicleNo, string model, int capacity, string remark)
        {
            _tpId = tpId;
            _vehicleType = vehicleType;
            _vehicleNo = vehicleNo;
            _model = model;
            _capacity = capacity;
            _remark = remark;
        }

        public string TpId { get => _tpId; set => _tpId = value; }
        public string VehicleType { get => _vehicleType; set => _vehicleType = value; }
        public string VehicleNo { get => _vehicleNo; set => _vehicleNo = value; }
        public string Model { get => _model; set => _model = value; }
        public string Remark { get => _remark; set => _remark = value; }
        public int Capacity { get => _capacity; set => _capacity = value; }
    }
}
