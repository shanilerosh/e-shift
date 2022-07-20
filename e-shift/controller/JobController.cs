using e_shift.bo.custom;
using e_shift.bo.custom.impl;
using e_shift.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.utility;

namespace e_shift.controller
{
    internal class JobController
    {
        private IJobBo bo = new JobBoImpl();
        
        public bool CreateJob(JobDto job) {
            return bo.AddJob(job);
        }


        public string GetJobId()
        {
            return bo.GetJobId();
        }


        public DataTable FetchPendingJobData(string cid)
        {
            return bo.FetchPendingJobData(cid);
        }
        
        public DataTable FetchDeclinedJobData(string cid)
        {
            return bo.FetchDeclinedJobData(cid);
        }
        
        public DataTable FetchAcceptedJobData(string cid)
        {
            return bo.FetchAcceptedJobData(cid);
        }
        
        public DataTable FetchAdminJobData(Status status)
        {
            return bo.FetchAdminJobData(status);
        }
        
        public JobDto FetchJobDataWithItemsById(string jobId)
        {
            return bo.FetchJobDtoByJobId(jobId);
        }
        
        public bool UpdateJob(JobDto jobDto, string jobId)
        {
            return bo.UpdateJob(jobDto, jobId);
        }
        
        public bool DeclineAcceptJob(string jobId, Status status)
        {
            return bo.DeclineAcceptJob(jobId, status);
        }
    }
}
