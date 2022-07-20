using System.Data.SqlClient;
using e_shift.db;
using e_shift.entity;
using e_shift.utility;

namespace e_shift.dao.custom.impl;

public class VehicleDaoImpl : IVehicleDao
{
    public IList<Vehicle> fetchAllVehicles()
    {
        var listOfVehicles = new List<Vehicle>();
        try
        {
            
            var reader = CrudUtil.ExecuteSelectQuery("SELECT * from db.vehicle");

            while (reader.Read()) {
                listOfVehicles.Add(new Vehicle(reader.GetInt32(1),reader.GetString(0),
                    reader.GetInt32(2)));
            }

            return listOfVehicles;
        }
        finally
        {
            DbConnection.GetInstance().GetConnection().Close();
        }
    }
}