using ITMCollegeService.Context;
using ITMCollegeService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.Repositories
{
    public interface ICollegeRepo
    {
        Task<IEnumerable<College>> GetDatas();
        Task<College> GetDataByIdAsync(int id);
        Task<College> NewData(College source);
        void UpdateData(College source);
        Task<bool> DeleteData(College entity);
    }
    public class CollegeRepo : RepositoryBase<College>, ICollegeRepo
    {
        public CollegeRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }

        public async Task<bool> DeleteData(College entity)
        {
            _itmCollegeContext.Colleges.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<College> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<College>> GetDatas()
        {
            return await _itmCollegeContext.Colleges.OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }

        public async Task<College> NewData(College source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Colleges.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(College source)
        {
            Update(source);
        }
    }
}
