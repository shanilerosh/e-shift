using e_shift.db;
using e_shift.dto;
using e_shift.entity;
using e_shift.utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dao.custom.impl
{
    internal class TransportUnitDaoIml : ITransportUnitDao
    {

        public bool Add(TransportUnit entity)
        {

            try
            {
                var keyValPair = new Dictionary<string, object>();

                keyValPair.Add("@tid", entity.TpId);
                keyValPair.Add("@vehicletype", entity.VehicleType);
                keyValPair.Add("@model", entity.Model);
                keyValPair.Add("@vehicleno", entity.VehicleNo);
                keyValPair.Add("@capacity", entity.Capacity);

                return CrudUtil.ExecuteUpdateDelete("INSERT INTO transportunit(tid,vehicletype,model,vehicleno,capacity) Values (@tid,@vehicletype,@model,@vehicleno,@capacity)",
                    keyValPair);
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        public bool Delete(string id)
        {
            var keyValPair = new Dictionary<string, object>();

            //adding cid for the where clause
            keyValPair.Add("@tid", id);

            return CrudUtil.ExecuteUpdateDelete("DELETE FROM transportunit WHERE tid = @tid",
                keyValPair);
        }

        public DataTable GetAll()
        {
            return CrudUtil.ExecuteSelectQueryForDataGrid("SELECT * FROM transportunit");
        }

        public string GetTransportUnitId()
        {
            try
            {
                using (SqlDataReader sqlDataReader = CrudUtil
                   .ExecuteSelectQuery("SELECT TOP 1 tid FROM transportunit ORDER BY tid DESC"))
                {
                    //.ExecuteSelectQuery("SELECT * FROM customer")) {
                    if (sqlDataReader.HasRows)
                    {

                        while (sqlDataReader.Read())
                        {
                            return sqlDataReader.GetString(0);
                        }
                    }
                }
            }
            finally
            {
                DbConnection.GetInstance().GetConnection().Close();
            }

            return null;
        }

        public DataTable SearchTransportUnit(string fields, string val)
        {

            return CrudUtil.ExecuteSelectQueryForDataGrid("SELECT * FROM transportunit WHERE " + fields + " LIKE '%" +val+ "%'");
            

        }

        public bool Update(TransportUnit entity)
        {
            var keyValPair = new Dictionary<string, object>();

            keyValPair.Add("@vehicletype", entity.VehicleType);
            keyValPair.Add("@model", entity.Model);
            keyValPair.Add("@vehicleno", entity.VehicleNo);
            keyValPair.Add("@capacity", entity.Capacity);
            keyValPair.Add("@tid", entity.TpId);

            return CrudUtil
                .ExecuteUpdateDelete("UPDATE transportunit SET vehicletype = @vehicletype ,model = @model ,vehicleno = @vehicleno ,capacity = @capacity WHERE tid = @tid",
                keyValPair);
        }
    }
}
