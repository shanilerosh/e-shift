using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dto
{
    public class VehicleDto
    {

        private  int _vid;
        private string _vehicleNo;
        private int _capacity;

        public VehicleDto(int vid, string vehicleNo, int capacity)
        {
            _vid = vid;
            _vehicleNo = vehicleNo;
            _capacity = capacity;
        }

        public int Vid { get => _vid; set => _vid = value; }
        public string VehicleNo { get => _vehicleNo; set => _vehicleNo = value; }
        public int Capacity { get => _capacity; set => _capacity = value; }


    }
}
