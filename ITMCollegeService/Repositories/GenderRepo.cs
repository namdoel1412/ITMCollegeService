using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface IGenderRepo
    {
        Task<IEnumerable<Gender>> GetDatas();
        Task<Gender> GetDataByIdAsync(int id);
        Task<Gender> NewData(Gender source);
        void UpdateData(Gender source);
        Task<bool> DeleteData(Gender entity);
    }
    public class GenderRepo : RepositoryBase<Gender>, IGenderRepo
    {
        public GenderRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
        public async Task<bool> DeleteData(Gender entity)
        {
            _itmCollegeContext.Genders.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<Gender> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Gender>> GetDatas()
        {
            return await _itmCollegeContext.Genders.OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }

        public async Task<Gender> NewData(Gender source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Genders.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Gender source)
        {
            Update(source);
        }
    }
}
