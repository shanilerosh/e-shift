using e_shift.dto;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.utility;

namespace e_shift.dao.custom
{
    internal interface IJobDao
    {
        String GetJobID();

        bool CreateJob(Job job);
        DataTable GetJobDataByStatusAndCustId(Status pending, string loggdUserCid);

        Job findJobById(String jobId);

        List<Item> findListOfItemsByJobId(String id);
        bool UpdateJob(string jobId, Job job);
    }
}
