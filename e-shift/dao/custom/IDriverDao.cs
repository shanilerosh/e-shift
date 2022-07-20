using e_shift.dto;
using e_shift.entity;

namespace e_shift.dao.custom;

public interface IDriverDao
{
    List<Driver> fetchAllDrivers();
}