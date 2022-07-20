using e_shift.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dto
{
    public class LoadItemDto
    {
        private string _driverName;
        private string _vehicleNo;
        private string _remark;
        private DateTime loadDate;

        public DateTime LoadDate
        {
            get => loadDate;
            set => loadDate = value;
        }
        

        private int vid;
        private int did;

        public int Vid
        {
            get => vid;
            set => vid = value;
        }

        public int Did
        {
            get => did;
            set => did = value;
        }

        public static LoadItemDto Builder()
        {
            return new LoadItemDto();
        }

        public LoadItemDto Build()
        {
            return this;
        }

        public LoadItemDto WithDriverName(string name)
        {
            Assert.HasText(name, "Driver Name cannot be emtpy");
            DriverName = name;
            return this;
        }
        
        public LoadItemDto WithLoadDateTime(DateTime time)
        {
            Assert.IsNull(time, "Load Date Time cannot be null");
            LoadDate = time;
            return this;
        }
        
        public LoadItemDto WithVehicle(string name)
        {
            Assert.HasText(name, "Vehicle Number cannot be empty");
            VehicleNo = name;
            return this;
        }
        
        public LoadItemDto WithRemark(string name)
        {
            Remark = (name);
            return this;
        }

        public string DriverName
        {
            get => _driverName;
            set => _driverName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string VehicleNo
        {
            get => _vehicleNo;
            set => _vehicleNo = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Remark
        {
            get => _remark;
            set => _remark = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
