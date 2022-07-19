using e_shift.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.bo.custom
{
    internal interface IItemUnitBo : ISuperBo
    {
        Boolean AddItem(ItemDto item);

        bool UpdateItem(ItemDto item, string tsId);

        bool DeleteItem(string tsId);

        DataTable GetAllItems();

        DataTable GetItem(string atr, string search);

        String GetItemId();

        ItemDto GetItemByName(string itemName);
    }
}
