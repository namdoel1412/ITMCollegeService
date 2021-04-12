using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Context;
using ITMCollegeService.Models;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface IAdminRepo
    {
        Task<IEnumerable<Admin>> GetDatas();
        Task<Admin> GetDataByIdAsync(int id);
        Task<Admin> NewData(Admin source);
        void UpdateData(Admin source);
        Task<bool> DeleteData(int id);
    }
    public class AdminRepo : RepositoryBase<Admin>, IAdminRepo
    {
        public AdminRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }

        public async Task<bool> DeleteData(int id)
        {
            var entity = await _itmCollegeContext.Admins.FirstOrDefaultAsync(item => item.Id == id);
            if (entity == null)
            {
                return false;
            }
            _itmCollegeContext.Admins.Remove(entity);
            return true;
        }

        public async Task<Admin> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Admin>> GetDatas()
        {
            return await _itmCollegeContext.Admins.OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }

        public async Task<Admin> NewData(Admin source)
        {
            Create(source);
            var entity = await _itmCollegeContext.Admins.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Admin source)
        {
            Update(source);
        }
    }
}
