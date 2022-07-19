using e_shift.dao.custom;
using e_shift.dao.custom.impl;
using e_shift.dto;
using e_shift.entity;
using e_shift.utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

                if (null == item) {
                    throw new InvalidDataException("Item not found with the item name "+obj.ItemName);
                }

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
            String jobId = dao.GetJobID();
            if (jobId != null)
            {
                String[] temp = jobId.Split("J");
                int tempNumber = int.Parse(temp[1]);
                tempNumber++;

                if (tempNumber < 10)
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
   
    }
}
