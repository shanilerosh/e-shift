using e_shift.entity;
using e_shift.utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.entity
{
    internal class Job
    {
        private string _jobId;
        private string _location;
        private DateTime _requiredDate;
        private string _remarks;
        private string _custId;
        private Status _status;

        //list of individual items
        private BindingList<Item> _itemNameList;

        public Job(string jobId, string location, DateTime requiredDate, string remarks, string custId, Status status, BindingList<Item> itemNameList)
        {
            _jobId = jobId;
            _location = location;
            _requiredDate = requiredDate;
            _remarks = remarks;
            _custId = custId;
            _status = status;
            _itemNameList = itemNameList;
        }

        public Job(string jobId, string location, DateTime requiredDate, string remarks, string custId)
        {
            _jobId = jobId;
            _location = location;
            _requiredDate = requiredDate;
            _remarks = remarks;
            _custId = custId;
        }

        public string JobId { get => _jobId; set => _jobId = value; }
        public string Location { get => _location; set => _location = value; }
        public DateTime RequiredDate { get => _requiredDate; set => _requiredDate = value; }
        public string Remarks { get => _remarks; set => _remarks = value; }
        public string CustId { get => _custId; set => _custId = value; }
        public Status Status { get => _status; set => _status = value; }
        internal BindingList<Item> ItemNameList { get => _itemNameList; set => _itemNameList = value; }
    }
}
