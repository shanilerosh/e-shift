using e_shift.bo.custom;
using e_shift.bo.custom.impl;
using e_shift.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.controller
{
    internal class ItemController
    {
        
        public bool SaveItem(ItemDto item) {
            return new ItemUnitBoImpl().AddItem(item);
        }

        public bool UpdateItem(ItemDto item, string id)
        {
            return new ItemUnitBoImpl().UpdateItem(item, id);
        }

        public bool DeleteItem(string id)
        {
            return new ItemUnitBoImpl().DeleteItem(id);
        }

        public DataTable GetAllItems()
        {
            return new ItemUnitBoImpl().GetAllItems();
        }

        public string GetItemId()
        {
            return new ItemUnitBoImpl().GetItemId();
        }

        public DataTable SearchItem(string atr, string search)
        {
            return new ItemUnitBoImpl().GetItem(atr, search);
        }


    }
}
