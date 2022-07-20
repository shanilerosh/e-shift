using e_shift.bo.custom;
using e_shift.bo.custom.impl;
using e_shift.dto;

namespace e_shift.controller
{
    internal class VehicleController
    {
        private IVehicleBo _bo = new VehicleBoImpl();
        
        public List<VehicleDto> fetchVehicles()
        {
            return _bo.FetchVehicles();
        }

    }
}
