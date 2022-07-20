using e_shift.dto;
using e_shift.entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.utility;

namespace e_shift.dao.custom
{
    internal interface ILoadDao
    {
        bool CreateLoad(string jobId, List<LoadItem> loadItems);
    }
}
