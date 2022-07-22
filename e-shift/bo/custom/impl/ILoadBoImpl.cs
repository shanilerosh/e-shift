using e_shift.dao.custom;
using e_shift.dao.custom.impl;
using e_shift.dto;
using e_shift.entity;
using e_shift.utility;

namespace e_shift.bo.custom.impl;

public class ILoadBoImpl : ILoadBo
{

    private IJobDao _jobDao = new JobDaoImpl();
    private ILoadDao _loadDao = new LoadDaoImpl();
    
    public bool CreateLoad(string jobId, List<LoadItemDto> loadItemDtos)
    {
        var job = _jobDao.FindJobById(jobId);
        
        Assert.IsNull(job, "Job Is null with the ID "+ jobId);

        var itemList = loadItemDtos.Select(obj => new LoadItem(obj.DriverName, obj.VehicleNo, 
            obj.Remark, obj.LoadDate, obj.Vid, obj.Did)).ToList();

        return _loadDao.CreateLoad(jobId, itemList);
    }
}