using e_shift.bo.custom;
using e_shift.bo.custom.impl;
using e_shift.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shift.utility;

namespace e_shift.controller
{
    internal class LoadController
    {
        private ILoadBo bo = new ILoadBoImpl();
        
        public bool CreateLoad(string jobId, List<LoadItemDto> loadItemDtos)
        {
            return bo.CreateLoad(jobId, loadItemDtos);
        }
    }
}
