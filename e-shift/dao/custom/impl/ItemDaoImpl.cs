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
    internal class ItemDaoImpl : IItemDao
    {

        public bool Add(Item entity)
        {

       
                var keyValPair = new Dictionary<string, object>();

                keyValPair.Add("@iid", entity.Iid);
                keyValPair.Add("@itemName", entity.ItemName);
                keyValPair.Add("@remark", entity.Remark);

                return CrudUtil.ExecuteUpdateDelete("INSERT INTO item(iid,itemName,remark) Values (@iid,@itemName,@remark)",
                    keyValPair);
            
        }

       

        public bool Delete(string id)
        {
            var keyValPair = new Dictionary<string, object>();

            //adding cid for the where clause
            keyValPair.Add("@iid", id);

            return CrudUtil.ExecuteUpdateDelete("DELETE FROM item WHERE iid = @iid",
                keyValPair);
        }

        public DataTable GetAll()
        {
            return CrudUtil.ExecuteSelectQueryForDataGrid("SELECT * FROM item");
        }

        public Item GetItemByName(string name)
        {
            try
            {
                using (SqlDataReader sqlDataReader = CrudUtil
                   .ExecuteSelectQuery("SELECT TOP 1 * FROM item WHERE itemName = '" + name + "'"))
                {
                    if (sqlDataReader.HasRows)
                    {

                        while (sqlDataReader.Read())
                        {
                            return new Item(sqlDataReader.GetString(0),
                                sqlDataReader.GetString(2), sqlDataReader.GetString(1));
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

        public string GetItemId()
        {
            try
            {
                using (SqlDataReader sqlDataReader = CrudUtil
                   .ExecuteSelectQuery("SELECT TOP 1 iid FROM item ORDER BY iid DESC"))
                {
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

        public DataTable SearchItem(string fields, string val)
        {

            return CrudUtil.ExecuteSelectQueryForDataGrid("SELECT * FROM item WHERE " + fields + " LIKE '%" +val+ "%'");
            

        }

        public bool Update(Item entity)
        {
            var keyValPair = new Dictionary<string, object>();

            keyValPair.Add("@itemName", entity.ItemName);
            keyValPair.Add("@remark", entity.Remark);
            keyValPair.Add("@iid", entity.Iid);

            return CrudUtil
                .ExecuteUpdateDelete("UPDATE item SET itemName = @itemName ,remark = @remark WHERE iid = @iid",
                keyValPair);
        }
    }
}
