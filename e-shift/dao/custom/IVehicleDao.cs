using e_shift.entity;

namespace e_shift.dao.custom;

public interface IVehicleDao
{
    IList<Vehicle> fetchAllVehicles();
}