using ITMCollegeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;
using ITMCollegeService.Identity;

namespace ITMCollegeService.Repositories
{
    public interface IUserRoleRepo
    {
        Task<IEnumerable<UserRole>> GetDatas();
        Task<UserRole> GetDataByIdAsync(int id);
        Task<UserRole> NewData(UserRole source);
        void UpdateData(UserRole source);
        Task<bool> DeleteData(UserRole entity);
        Task<IEnumerable<string>> UserRoles(LoginModel user);
    }
    public class UserRoleRepo : RepositoryBase<UserRole>, IUserRoleRepo
    {
        public UserRoleRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }

        public async Task<bool> DeleteData(UserRole entity)
        {
            _itmCollegeContext.UserRoles.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<UserRole> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<UserRole>> GetDatas()
        {
            return await _itmCollegeContext.UserRoles.OrderBy(x => x.UserId).AsNoTracking().ToListAsync();
        }

        public async Task<UserRole> NewData(UserRole source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.UserRoles.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(UserRole source)
        {
            Update(source);
        }

        public async Task<IEnumerable<string>> UserRoles(LoginModel user)
        {
            IList<string> res = new List<string>();
            var entity = await _itmCollegeContext.Users.Where(x => x.Username == user.Username && x.Password == user.Password)
                .FirstOrDefaultAsync();
            var lstRoleId = await _itmCollegeContext.UserRoles.Where(x => x.UserId == entity.Id)
                .ToListAsync();
            foreach(var item in lstRoleId)
            {
                res.Add(item.Role.Name);
            }

            return res;
        }
    }
}
