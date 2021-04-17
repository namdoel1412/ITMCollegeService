using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;
using ITMCollegeService.Identity;

namespace ITMCollegeService.Repositories
{
    public interface IUserRepo
    {
        Task<IEnumerable<User>> GetDatas();
        Task<User> GetDataByIdAsync(int id);
        Task<User> NewData(User source);
        void UpdateData(User source);
        Task<bool> DeleteData(User entity);
        Task<User> CheckUser(LoginModel user);
        Task<bool> CheckExistedUser(LoginModel user);

    }
    public class UserRepo : RepositoryBase<User>, IUserRepo
    {
        public UserRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
        public async Task<bool> DeleteData(User entity)
        {
            _itmCollegeContext.Users.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<User> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<User>> GetDatas()
        {
            return await _itmCollegeContext.Users.OrderBy(x => x.Username).AsNoTracking().ToListAsync();
        }

        public async Task<User> NewData(User source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Users.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(User source)
        {
            Update(source);
        }

        public async Task<User> CheckUser(LoginModel user)
        {
            var entity = await _itmCollegeContext.Users.Where(x => x.Username == user.Username && x.Password == user.Password)
                .FirstOrDefaultAsync();
            return entity;
        }

        public async Task<bool> CheckExistedUser(LoginModel user)
        {
            var entity = await _itmCollegeContext.Users.Where(x => x.Username == user.Username)
                .FirstOrDefaultAsync();
            return entity == null;
        }
    }
}
