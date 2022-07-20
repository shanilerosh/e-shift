using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.entity
{
    public class LoadItem
    {
        private string _driverName;
        private string _vehicleNo;
        private string _remark;
        private DateTime loadDate;
        
        private int vid;
        private int did;

        public LoadItem(string driverName, string vehicleNo, string remark, DateTime loadDate, int vid, int did)
        {
            _driverName = driverName;
            _vehicleNo = vehicleNo;
            _remark = remark;
            this.loadDate = loadDate;
            this.vid = vid;
            this.did = did;
        }

        public string DriverName { get => _driverName; set => _driverName = value; }
        public string VehicleNo { get => _vehicleNo; set => _vehicleNo = value; }
        public string Remark { get => _remark; set => _remark = value; }
        public DateTime LoadDate { get => loadDate; set => loadDate = value; }
        public int Vid { get => vid; set => vid = value; }
        public int Did { get => did; set => did = value; }
    }
}
