using e_shift.db;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.utility;

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
                    SqlCommand("INSERT INTO job(jobId,jobLocation,requiredDateTime,custId,jobStatus,remarks) VALUES (@jobId,@jobLocation,@requiredDateTime,@custId,@jobStatus,@remarks)", conn, transaction);
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
                    SqlCommand("INSERT INTO jobDetail(jobId,iid,qty) Values (@jobId,@iid,@qty)", conn, transaction);

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

        public DataTable GetJobDataByStatusAndCustId(Status status, string loggdUserCid)
        {

            return CrudUtil.ExecuteSelectQueryForDataGrid("SELECT jobId AS [Job Id],jobLocation As [Location],createdDateTime AS [Created At],jobStatus As [Job Status]" +
                                                          " FROM job WHERE jobStatus = '" + status +
                                                   "' AND custId = '" + loggdUserCid + "' ORDER BY createdDateTime DESC");
        }

        public Job findJobById(string jobId)
        {
            try
            {
                using (SqlDataReader sqlDataReader = CrudUtil
                           .ExecuteSelectQuery("SELECT TOP 1 * FROM job WHERE jobId = '"+jobId+"'"))
                {
                    if (sqlDataReader.HasRows)
                    {

                        while (sqlDataReader.Read())
                        {
                            
                            return new Job(sqlDataReader.GetString(0),
                                sqlDataReader.GetString(1), sqlDataReader.GetDateTime(2),
                                sqlDataReader.GetString(6), sqlDataReader.GetString(4));
                            
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

        public List<Item> findListOfItemsByJobId(string id)
        {

            var listOfItems = new List<Item>();
            try
            {
                
                using (SqlDataReader sqlDataReader = CrudUtil
                           .ExecuteSelectQuery(string.Format(@"Select item.itemName, job.qty FROM jobDetail As job
                    INNER JOIN item As item ON job.iid = item.iid
                WHERE jobId = '{0}'", id)))
                {
                    if (sqlDataReader.HasRows)
                    {

                        while (sqlDataReader.Read())
                        {
                            listOfItems.Add(new Item(sqlDataReader.GetString(0),
                                sqlDataReader.GetInt32(1)));
                        }
                    }
                }

                return listOfItems;
            }
            finally
            {
                DbConnection.GetInstance().GetConnection().Close();
            }
        }

        public bool UpdateJob(string jobId, Job job)
        {
            /*Get the singleton connection*/
            var conn = DbConnection.GetInstance().GetConnection();

            conn.Open();
            //begin transaction
            var transaction = conn.BeginTransaction();

            try
            {
                //insert to master job table
                using (var jobCommand = new SqlCommand("UPDATE job SET jobLocation = @jobLocation , requiredDateTime = @requiredDateTime ,remarks = @remarks WHERE jobId = @jobId", conn, transaction))
                {
                    jobCommand.Parameters.AddWithValue("@jobLocation", job.Location);
                    jobCommand.Parameters.AddWithValue("@requiredDateTime", job.RequiredDate);
                    jobCommand.Parameters.AddWithValue("@remarks", job.Remarks);
                    jobCommand.Parameters.AddWithValue("@jobId", jobId);
                

                    jobCommand.ExecuteNonQuery();
                }

                //delete all records associate table
                using (var jobDetailDeleteCmd = new SqlCommand("DELETE from jobDetail WHERE jobId = @jobId", conn, transaction))
                {
                    jobDetailDeleteCmd.Parameters.AddWithValue("@jobId", jobId);

                    jobDetailDeleteCmd.ExecuteNonQuery();
                }

                //insert to associate table jobDetails

                foreach (var jobItem in job.ItemNameList)
                {
                    using (var jobDetailsCommand = new SqlCommand("INSERT INTO jobDetail(jobId,iid,qty) Values (@jobId,@iid,@qty)", conn, transaction))
                    {
                        jobDetailsCommand.Parameters.AddWithValue("@jobId", job.JobId);
                        jobDetailsCommand.Parameters.AddWithValue("@iid", jobItem.Iid);
                        jobDetailsCommand.Parameters.AddWithValue("@qty", jobItem.Qty);

                        jobDetailsCommand.ExecuteNonQuery();
                    }
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

        public DataTable GetJobDataByStatus(string status)
        {
            return CrudUtil.ExecuteSelectQueryForDataGrid(
                $"SELECT jobId AS [Job Id],jobLocation" +
                $" As [Location],createdDateTime AS [Created At],jobStatus As [Job Status],c.firstname AS [Customer Name]" +
                $" FROM job INNER JOIN customer c on c.cid = job.custId WHERE jobStatus = '{status}' ORDER BY createdDateTime DESC");
        }

        public bool UpdateJobStatus(string jobId, string status)
        {
            /*Get the singleton connection*/
            var conn = DbConnection.GetInstance().GetConnection();

            conn.Open();
            
            try
            {
                //insert to master job table
                using (var jobCommand = new SqlCommand("UPDATE job SET jobStatus = @jobStatus WHERE jobId = @jobId", conn))
                {
                    jobCommand.Parameters.AddWithValue("@jobStatus", status);
                    jobCommand.Parameters.AddWithValue("@jobId", jobId);
                

                    jobCommand.ExecuteNonQuery();
                }

                return true;
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
                   .ExecuteSelectQuery("SELECT TOP 1 jobId FROM job ORDER BY jobId DESC"))
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
    }
}
