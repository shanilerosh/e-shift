using System.Data.SqlClient;
using e_shift.db;
using e_shift.entity;
using e_shift.utility;

namespace e_shift.dao.custom.impl;

public class LoadDaoImpl : ILoadDao
{
    public bool CreateLoad(string jobId, List<LoadItem> loadItems)
    {
        
        /*Get the singleton connection*/
            var conn = DbConnection.GetInstance().GetConnection();

            conn.Open();
            //begin transaction
            var transaction = conn.BeginTransaction();

            try
            {
                //insert into job tables
                foreach (var loadItem in loadItems)
                {
                    using (var loadCmd = new SqlCommand("INSERT INTO load(did,vid,jid,loadDateTime) Values (@did,@vid,@jid,@loadDateTime)"
                               , conn, transaction))
                    {
                        loadCmd.Parameters.AddWithValue("@did", loadItem.Did);
                        loadCmd.Parameters.AddWithValue("@vid", loadItem.Vid);
                        loadCmd.Parameters.AddWithValue("@jid", jobId);
                        loadCmd.Parameters.AddWithValue("@loadDateTime", loadItem.LoadDate);
                        
                        loadCmd.ExecuteNonQuery();
                    }

                }
                
                //update the job table
                using (var jobCommand = new SqlCommand("UPDATE job SET jobStatus = @jobStatus WHERE jobId = @jobId", conn, transaction))
                {
                    jobCommand.Parameters.AddWithValue("@jobStatus", Status.COMPLETED.ToString());
                    jobCommand.Parameters.AddWithValue("@jobId", jobId);
                    
                    jobCommand.ExecuteNonQuery();
                }
                
                //if success commit transaction
                transaction.Commit();
                return true;

            }
            catch (Exception e)
            {
                //if an exception occured rollback to the original state
                transaction.Rollback();
                throw;
            }
            finally
            {
                conn.Close();
            }

    }
}