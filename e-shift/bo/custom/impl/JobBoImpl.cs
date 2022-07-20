using e_shift.dao.custom;
using e_shift.dao.custom.impl;
using e_shift.dto;
using e_shift.entity;
using e_shift.utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.bo.custom.impl
{
    internal class JobBoImpl : IJobBo
    {

        private IJobDao dao = new JobDaoImpl();
        private IItemDao itemDao = new ItemDaoImpl();
        private ICustomerDao custDao = new CustomerDaoImpl();

        public bool AddJob(JobDto job)
        {

            //validate customer
            var customer = custDao.findByCustId(job.CustId);

            if (null == customer) {
                throw new InvalidDataException("Customer not found with the cust Id" + job.CustId);
            }

            //validate items in the db and collect to a collection
            List<Item> listOfItems = job.ItemNameList.Select(obj => {
                var item = itemDao.GetItemByName(obj.ItemName);
                //assert if item is not there in the db
                Assert.IsNull(item, "Item not found with the item name "+obj.ItemName);
                item.Qty = obj.Qty;
                return item;
            }).ToList();

            //create the job object
            Job jobEntity = new Job(job.JobId, job.Location, job.RequiredDate, job.Remarks, job.CustId, Status.PENDING,
                new BindingList<Item>(listOfItems));


            return dao.CreateJob(jobEntity);
        }

        public string GetJobId()
        {
            var jobId = dao.GetJobID();
            if (jobId != null)
            {
                var temp = jobId.Split("J");
                var tempNumber = int.Parse(temp[1]);
                tempNumber++;

                if  (tempNumber < 10)
                {
                    jobId = "J00" + tempNumber;
                }
                else if (tempNumber < 100)
                {
                    jobId = "J0" + tempNumber;
                }
                else
                {
                    jobId = "J" + tempNumber;
                }
            }
            else
            {
                jobId = "J001";
            }

            return jobId;
        }

        public DataTable FetchPendingJobData(string loggdUserCid)
        {
            //validate customer
            var customer = custDao.findByCustId(loggdUserCid);
            
            Assert.IsNull(customer,"No Customer found with the id " +loggdUserCid);

            return dao.GetJobDataByStatusAndCustId(Status.PENDING, loggdUserCid);
        }

        public JobDto FetchJobDtoByJobId(string jobId)
        {
            //fetch the job object
            var job = dao.findJobById(jobId);
            
            Assert.IsNull(job, "No job found with the id "+job.JobId);
            
            //fetch item data
            var jobItemDtos = dao.findListOfItemsByJobId(jobId).Select(obj => JobItemDto.Builder().WithQty(obj.Qty.ToString()).WithItemName(obj.ItemName)
                .Build()).ToList();

            var jobDto = JobDto.Builder().WithLocation(job.Location)
                .WithRemark(job.Remarks).WithJobId(job.JobId)
                .WithRequiredDate(job.RequiredDate);

            jobDto.ItemNameList = new BindingList<JobItemDto>(jobItemDtos);
            
            return jobDto;
        }

        public bool UpdateJob(JobDto jobDto, string jobId)
        {
            //fetch the job object
            var job = dao.findJobById(jobId);
            
            Assert.IsNull(job, "No job found with the id "+job.JobId);

            job.Location = jobDto.Location;
            job.Remarks = jobDto.Remarks;
            job.RequiredDate = jobDto.RequiredDate;
            //only pending jobs can be updated
            job.Status = Status.PENDING;

            //validate items in the db and collect to a collection
            List<Item> listOfItems = jobDto.ItemNameList.Select(obj => {
                var item = itemDao.GetItemByName(obj.ItemName);
                //assert if item is not there in the db
                Assert.IsNull(item, "Item not found with the item name "+obj.ItemName);
                item.Qty = obj.Qty;
                return item;
            }).ToList();

            job.ItemNameList = new BindingList<Item>(listOfItems);

            return dao.UpdateJob(jobId, job);

        }

        public DataTable FetchDeclinedJobData(string cid)
        {
            //validate customer
            var customer = custDao.findByCustId(cid);
            
            Assert.IsNull(customer,"No Customer found with the id " +cid);

            return dao.GetJobDataByStatusAndCustId(Status.DECLINED, cid);
        }

        public DataTable FetchAcceptedJobData(string cid)
        {
            //validate customer
            var customer = custDao.findByCustId(cid);
            
            Assert.IsNull(customer,"No Customer found with the id " +cid);

            return dao.GetJobDataByStatusAndCustId(Status.ACCEPTED, cid);
        }

        public DataTable FetchAdminJobData(Status status)
        {
            return dao.GetJobDataByStatus(status.ToString());
        }

        public bool DeclineAcceptJob(string jobId, Status status)
        {
            //fetch the job object
            var job = dao.findJobById(jobId);
            
            Assert.IsNull(job, "No job found with the id "+job.JobId);
            
            return dao.UpdateJobStatus(jobId, status.ToString());
        }
    }
}
