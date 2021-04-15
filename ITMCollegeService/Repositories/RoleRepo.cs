using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface IRoleRepo
    {
        Task<IEnumerable<Role>> GetDatas();
        Task<Role> GetDataByIdAsync(int id);
        Task<Role> NewData(Role source);
        void UpdateData(Role source);
        Task<bool> DeleteData(Role entity);
    }
    public class RoleRepo : RepositoryBase<Role>, IRoleRepo
    {
        public RoleRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
        public async Task<bool> DeleteData(Role entity)
        {
            _itmCollegeContext.Roles.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<Role> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Role>> GetDatas()
        {
            return await _itmCollegeContext.Roles.OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }

        public async Task<Role> NewData(Role source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Roles.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Role source)
        {
            Update(source);
        }
    }
}
