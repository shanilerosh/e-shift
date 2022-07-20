using e_shift.dao.custom;
using e_shift.dao.custom.impl;
using e_shift.dto;
using e_shift.entity;

namespace e_shift.bo.custom.impl;

public class VehicleBoImpl : IVehicleBo
{
    private IVehicleDao _dao = new VehicleDaoImpl();
    
    public List<VehicleDto> FetchVehicles()
    {
        return _dao.fetchAllVehicles().Select(obj => new VehicleDto(obj.Vid, obj.VehicleNo, obj.Capacity))
            .ToList();
    }
}