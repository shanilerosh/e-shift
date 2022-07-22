using e_shift.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dto
{
    internal class ItemDto
    {
        private String _iid;
        private String _itemName;
        private String _remark;
        private int _minToCarry;

        public string Iid { get => _iid; set => _iid = value; }
        public string ItemName { get => _itemName; set => _itemName = value; }
        public string Remark { get => _remark; set => _remark = value; }
        
        public int MinToCarry{ get => _minToCarry; set => _minToCarry = value; }

        public ItemDto(string iid, string itemName, string remark, int minToCarry)
        {
            _iid = iid;
            _itemName = itemName;
            _remark = remark;
            _minToCarry = minToCarry;
        }

        public ItemDto()
        {
        }


        //fluent builder
        public static ItemDto Builder() { 
            return new ItemDto();
        }


        public ItemDto WithItemName(string name) {
           Assert.HasText(name, "Item Name cannot be empty");
           this.ItemName = name;
           return this;
        }
        
        public ItemDto WithMinToCarry(string name) {
            Assert.HasText(name, "Min to carry cannot be empty");
            Assert.IsNumeric(name, "Min to carry should be numerical");
            this.MinToCarry = int.Parse(name);
            return this;
        }

        public ItemDto WithRemark(string name)
        {
            this.Remark = null == name ? "" : name;
            return this;
        }

        public ItemDto Build() {
            return this; 
        }

        

    }
}
