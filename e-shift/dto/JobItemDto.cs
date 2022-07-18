using e_shift.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.dto
{
    internal class JobItemDto
    {
        private string _itemName;
        private int _qty;

        public JobItemDto(string itemName, int qty)
        {
            _itemName = itemName;
            _qty = qty;
        }

        public JobItemDto()
        {
        }

        public string ItemName { get => _itemName; set => _itemName = value; }
        public int Qty { get => _qty; set => _qty = value; }

        public static JobItemDto Builder() {
            return new JobItemDto();
        }

        public JobItemDto WithItemName(string name) {
            Assert.HasText(name, "Item Name cannot be empty");
            this.ItemName = name;
            return this;
        }

        public JobItemDto WithQty(int qty)
        {
            Assert.HasNumber(qty, "Qty Cannot be empty");
            this.Qty = qty;
            return this;
        }

        public JobItemDto Build() {
            return this;
        }
    }
}
