using e_shift.dao.custom;
using e_shift.dao.custom.impl;
using e_shift.dto;
using e_shift.entity;

namespace e_shift.bo.custom.impl;

public class DriverBoImpl : IDriverBo
{
    private IDriverDao _dao = new DriverDaoImpl();
    
    
    public List<DriverDto> FetchDrivers()
    {
        return _dao.fetchAllDrivers().Select(obj => new DriverDto(obj.Did, obj.DriverName))
            .ToList();
    }
}