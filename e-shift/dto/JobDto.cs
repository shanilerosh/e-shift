using e_shift.entity;
using e_shift.utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dto
{
    internal class JobDto
    {
        private string _jobId;
        private string _location;
        private DateTime _requiredDate;
        private string _remarks;

        //list of individual items
        private BindingList<JobItemDto> _itemNameList;

        public string JobId { get => _jobId; set => _jobId = value; }
        public string Location { get => _location; set => _location = value; }
        public DateTime RequiredDate { get => _requiredDate; set => _requiredDate = value; }
        public string Remarks { get => _remarks; set => _remarks = value; }

        public static Job Builder()
        {
            return new Job();
        }

        public Job WithLocation(string name)
        {
            Assert.HasText(name, "Location Cannot be empty");
            this.Location = name;
            return this;
        }

        public Job WithRemark(string name)
        {
            this.Remarks = null == name ? "" : name;
            return this;
        }

        public Job WithRequiredDate(DateTime name)
        {
            Assert.IsNull(name, "Required Date Cannot be empty");
            this.RequiredDate = name;
            return this;
        }

        public JobItemDto WithQty(int qty)
        {
            Assert.HasNumber(qty, "Qty Cannot be empty");
            this.Qty = qty;
            return this;
        }

        public JobItemDto Build()
        {
            return this;
        }
    }
}
