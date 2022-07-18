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

        //list of individual items
        private BindingList<Item> _itemNameList;

        public string JobId { get => _jobId; set => _jobId = value; }
        public string Location { get => _location; set => _location = value; }
        public DateTime RequiredDate { get => _requiredDate; set => _requiredDate = value; }
        public string Remarks { get => _remarks; set => _remarks = value; }
        internal BindingList<Item> ItemNameList { get => _itemNameList; set => _itemNameList = value; }
    }
