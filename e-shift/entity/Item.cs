using System;
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

        public Item(string iid, string remark, string itemName)
        {
            _iid = iid;
            _remark = remark;
            _itemName = itemName;
        }

        public string Iid { get => _iid; set => _iid = value; }
        public string Remark { get => _remark; set => _remark = value; }
        public string ItemName { get => _itemName; set => _itemName = value; }
    }
}
