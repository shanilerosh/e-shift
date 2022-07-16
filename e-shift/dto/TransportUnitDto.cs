using e_shift.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dto
{
    internal class TransportUnitDto
    {
        private String _vehicleType;
        private String _vehicleNo;
        private String _model ;
        private int _capacity ;
        private String _remark;

        public TransportUnitDto(string vehicleType, string vehicleNo, string model, int capacity, string remark)
        {
            _vehicleType = vehicleType;
            _vehicleNo = vehicleNo;
            _model = model;
            _capacity = capacity;
            _remark = remark;
        }

        public TransportUnitDto()
        {
        }

        public string VehicleType { get => _vehicleType; set => _vehicleType = value; }
        public string VehicleNo { get => _vehicleNo; set => _vehicleNo = value; }
        public string Model { get => _model; set => _model = value; }
        public int Capacity { get => _capacity; set => _capacity = value; }
        public string Remark { get => _remark; set => _remark = value; }


        //fluent builder
        public static TransportUnitDto Builder() { 
            return new TransportUnitDto();
        }

        public TransportUnitDto WithVehicleType(string name) {
           Assert.HasText(name, "Vehcle type cannot be empty");
           this.VehicleType = name;
           return this;
        }

        public TransportUnitDto WithVehicleNo(string name)
        {
            Assert.HasText(name, "Vehicle No cannot be empty");
            this.VehicleNo = name;
            return this;
        }

        public TransportUnitDto WithModel(string name)
        {
            Assert.HasText(name, "Model cannot be empty");
            this.Model = name;
            return this;
        }

        public TransportUnitDto WithCapacity(int capacity)
        {
            Assert.IsNull(capacity, "Capacity cannot be empty");
            Assert.IsNumeric(capacity.ToString(), "Capacity should be numerical");
            this.Capacity = capacity;
            return this;
        }



        public TransportUnitDto WithRemark(string remark)
        {
            this._remark = null == remark ? string.Empty : remark;
            return this;
        }

        public TransportUnitDto build() {
            return this;
        }


    }
}
