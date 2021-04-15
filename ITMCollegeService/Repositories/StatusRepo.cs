using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface IStatusRepo
    {
        Task<IEnumerable<Status>> GetDatas();
        Task<Status> GetDataByIdAsync(int id);
        Task<Status> NewData(Status source);
        void UpdateData(Status source);
        Task<bool> DeleteData(Status entity);
    }
    public class StatusRepo : RepositoryBase<Status>, IStatusRepo
    {
        public StatusRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }

        public async Task<bool> DeleteData(Status entity)
        {
            _itmCollegeContext.Statuses.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<Status> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Status>> GetDatas()
        {
            return await _itmCollegeContext.Statuses.OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }

        public async Task<Status> NewData(Status source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Statuses.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Status source)
        {
            Update(source);
        }
    }
}
