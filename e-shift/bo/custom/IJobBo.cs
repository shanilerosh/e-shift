﻿using e_shift.dto;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.utility;

namespace e_shift.bo.custom
{
    internal interface IJobBo
    {

        bool AddJob(JobDto job);

        string GetJobId();
        
        DataTable FetchPendingJobData(string cid);
        
        JobDto FetchJobDtoByJobId(string cid);
        bool UpdateJob(JobDto jobDto, string jobId);
        DataTable FetchDeclinedJobData(string cid);
        DataTable FetchAcceptedJobData(string cid);
        DataTable FetchAdminJobData(Status status);
        bool DeclineAcceptJob(string jobId, Status status);
        
        DataTable FetchCompletedJobData(string cid);
    }
}
