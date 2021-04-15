using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface IPreviouseducationRepo
    {
        Task<IEnumerable<Previouseducation>> GetDatas();
        Task<Previouseducation> GetDataByIdAsync(int id);
        Task<Previouseducation> NewData(Previouseducation source);
        void UpdateData(Previouseducation source);
        Task<bool> DeleteData(Previouseducation entity);
    }
    public class PreviouseducationRepo : RepositoryBase<Previouseducation>, IPreviouseducationRepo
    {
        public PreviouseducationRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
        public async Task<bool> DeleteData(Previouseducation entity)
        {
            _itmCollegeContext.Previouseducations.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<Previouseducation> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Previouseducation>> GetDatas()
        {
            return await _itmCollegeContext.Previouseducations.OrderBy(x => x.School).AsNoTracking().ToListAsync();
        }

        public async Task<Previouseducation> NewData(Previouseducation source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Previouseducations.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Previouseducation source)
        {
            Update(source);
        }
    }
}
