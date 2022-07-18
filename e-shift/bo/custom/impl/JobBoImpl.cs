using e_shift.dao.custom;
using e_shift.dao.custom.impl;
using e_shift.dto;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.bo.custom.impl
{
    internal class JobBoImpl : IJobBo
    {

        private IJobDao dao = new IJobDaoImpl();

        public bool AddJob(Job job)
        {

            dao.CreateJob
        }
    }
}
