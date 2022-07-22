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

        private IItemUnitBo _bo = new ItemUnitBoImpl();
        
        public bool SaveItem(ItemDto item) {
            return _bo.AddItem(item);
        }

        public bool UpdateItem(ItemDto item, string id)
        {
            return _bo.UpdateItem(item, id);
        }

        public bool DeleteItem(string id)
        {
            return _bo.DeleteItem(id);
        }

        public DataTable GetAllItems()
        {
            return _bo.GetAllItems();
        }

        public string GetItemId()
        {
            return _bo.GetItemId();
        }

        public DataTable SearchItem(string atr, string search)
        {
            return _bo.GetItem(atr, search);
        }


    }
}
