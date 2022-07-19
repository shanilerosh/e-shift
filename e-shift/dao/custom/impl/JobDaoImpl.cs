using e_shift.db;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dao.custom.impl
{
    internal class JobDaoImpl : IJobDao
    {
        public bool CreateJob(Job job)
        {
            /*Get the singleton connection*/
            var conn = DbConnection.GetInstance().GetConnection();

            conn.Open();
            //begin transaction
            var transaction = conn.BeginTransaction();

            try
            {
                //insert to master job table
                var jobCommand = new
                    SqlCommand("INSERT INTO db.job(jobId,jobLocation,requiredDateTime,custId,jobStatus,remarks) VALUES (@jobId,@jobLocation,@requiredDateTime,@custId,@jobStatus,@remarks)", conn, transaction);
                jobCommand.Parameters.AddWithValue("@jobId", job.JobId);
                jobCommand.Parameters.AddWithValue("@jobLocation", job.Location);
                jobCommand.Parameters.AddWithValue("@requiredDateTime", job.RequiredDate);
                jobCommand.Parameters.AddWithValue("@custId", job.CustId);
                jobCommand.Parameters.AddWithValue("@jobStatus", job.Status.ToString());
                jobCommand.Parameters.AddWithValue("@remarks", job.Remarks);
                

                jobCommand.ExecuteNonQuery();

                //insert to associate table jobDetails

                foreach (var jobItem in job.ItemNameList)
                {
                    var jobDetailsCommand = new
                    SqlCommand("INSERT INTO db.jobDetail(jobId,iid,qty) Values (@jobId,@iid,@qty)", conn, transaction);

                    jobDetailsCommand.Parameters.AddWithValue("@jobId", job.JobId);
                    jobDetailsCommand.Parameters.AddWithValue("@iid", jobItem.Iid);
                    jobDetailsCommand.Parameters.AddWithValue("@qty", jobItem.Qty);

                    jobDetailsCommand.ExecuteNonQuery();
                }

                //if success commit transaction
                transaction.Commit();
                return true;

            }
            catch (Exception e)
            {
                //if an excemption occured rollback to the original state
                transaction.Rollback();
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public string GetJobID()
        {
            try
            {
                using (SqlDataReader sqlDataReader = CrudUtil
                   .ExecuteSelectQuery("SELECT TOP 1 jobId FROM db.job ORDER BY jobId DESC"))
                {
                    //.ExecuteSelectQuery("SELECT * FROM db.customer")) {
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
    }
}
