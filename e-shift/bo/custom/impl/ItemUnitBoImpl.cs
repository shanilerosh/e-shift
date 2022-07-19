using e_shift.dao.custom;
using e_shift.dao.custom.impl;
using e_shift.dto;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shift.bo.custom.impl
{
    internal class ItemUnitBoImpl : IItemUnitBo
    {

        private IItemDao dao = new ItemDaoImpl();

        public bool AddItem(ItemDto item)
        {
            var itemByName = dao.GetItemByName(item.ItemName);

            if (null != itemByName)
            {
                throw new InvalidDataException("Item name cannot be duplicated. Please change item name "+item.ItemName);
            }
            
            return dao
                .Add(new Item(GetItemId(), item.Remark, item.ItemName));
        }

        public bool DeleteItem(string tsId)
        {
            return dao.Delete(tsId);
        }

        public DataTable GetAllItems()
        {
            return dao.GetAll();
        }

        public DataTable GetItem(string atr, string search)
        {
            return dao.SearchItem(atr, search);
        }

        public ItemDto GetItemByName(string itemName)
        {
            throw new NotImplementedException();
        }

        public string GetItemId()
        {
            String transportUnitId = dao.GetItemId();
            if (transportUnitId != null)
            {
                String[] temp = transportUnitId.Split("I");
                int tempNumber = int.Parse(temp[1]);
                tempNumber++;

                if (tempNumber < 10)
                {
                    transportUnitId = "I00" + tempNumber;
                }
                else if (tempNumber < 100)
                {
                    transportUnitId = "I0" + tempNumber;
                }
                else
                {
                    transportUnitId = "I" + tempNumber;
                }
            }
            else
            {
                transportUnitId = "I001";
            }

            return transportUnitId;
        }

      

        public bool UpdateItem(ItemDto item, string iid)
        {
            return dao.Update(new Item(iid, item.Remark, item.ItemName));
        }
    }
}
