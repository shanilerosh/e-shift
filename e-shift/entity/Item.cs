﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.entity
{
    internal class Item
    {

        private String _iid;
        private String _remark;
        private String _itemName;
        private int _minToCarry;

        //for keeping item qty
        private int qty;

        public Item(string iid, string remark, string itemName, int minToCarry)
        {
            _iid = iid;
            _remark = remark;
            _itemName = itemName;
            _minToCarry = minToCarry;
        }

        public Item(string itemName, int qty)
        {
            _itemName = itemName;
            this.qty = qty;
        }

        public string Iid { get => _iid; set => _iid = value; }
        public string Remark { get => _remark; set => _remark = value; }
        public string ItemName { get => _itemName; set => _itemName = value; }
        public int Qty { get => qty; set => qty = value; }
        
        public int MinToCarry{ get => _minToCarry; set => _minToCarry = value; }
    }
}
