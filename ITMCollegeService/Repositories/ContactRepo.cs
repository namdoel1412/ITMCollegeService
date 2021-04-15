using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface IContactRepo
    {
        Task<IEnumerable<Contact>> GetDatas();
        Task<Contact> GetDataByIdAsync(int id);
        Task<Contact> NewData(Contact source);
        void UpdateData(Contact source);
        Task<bool> DeleteData(Contact entity);
    }
    public class ContactRepo : RepositoryBase<Contact>, IContactRepo
    {
        public ContactRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
        public async Task<bool> DeleteData(Contact entity)
        {
            _itmCollegeContext.Contacts.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<Contact> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Contact>> GetDatas()
        {
            return await _itmCollegeContext.Contacts.OrderBy(x => x.Phone).AsNoTracking().ToListAsync();
        }

        public async Task<Contact> NewData(Contact source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Contacts.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Contact source)
        {
            Update(source);
        }
    }
}
