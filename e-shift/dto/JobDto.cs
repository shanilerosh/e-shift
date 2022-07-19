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
        private string _custId;

        //list of individual items
        private BindingList<JobItemDto> _itemNameList;

        public string JobId { get => _jobId; set => _jobId = value; }
        public string Location { get => _location; set => _location = value; }
        public DateTime RequiredDate { get => _requiredDate; set => _requiredDate = value; }
        public string Remarks { get => _remarks; set => _remarks = value; }
        internal BindingList<JobItemDto> ItemNameList { get => _itemNameList; set => _itemNameList = value; }

        public static JobDto Builder()
        {
            return new JobDto();
        }

        public JobDto WithLocation(string name)
        {
            Assert.HasText(name, "Location Cannot be empty");
            this.Location = name;
            return this;
        }

        public JobDto WithRemark(string name)
        {
            this.Remarks = null == name ? "" : name;
            return this;
        }

        public JobDto WithRequiredDate(DateTime name)
        {
            Assert.IsNull(name, "Required Date Cannot be empty");
            this.RequiredDate = name;
            return this;
        }


        public JobDto Build()
        {
            return this;
        }
    }
}
