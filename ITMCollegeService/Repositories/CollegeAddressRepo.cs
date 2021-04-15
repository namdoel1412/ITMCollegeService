using ITMCollegeService.Context;
using ITMCollegeService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.Repositories
{
    public interface ICollegeAddressRepo
    {
        Task<IEnumerable<Collegeaddress>> GetDatas();
        Task<Collegeaddress> GetDataByIdAsync(int id);
        Task<Collegeaddress> NewData(Collegeaddress source);
        void UpdateData(Collegeaddress source);
        Task<bool> DeleteData(Collegeaddress entity);
    }
    public class CollegeAddressRepo : RepositoryBase<Collegeaddress>, ICollegeAddressRepo
    {
        public CollegeAddressRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }

        public async Task<bool> DeleteData(Collegeaddress entity)
        {
            _itmCollegeContext.Collegeaddresses.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<Collegeaddress> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Collegeaddress>> GetDatas()
        {
            return await _itmCollegeContext.Collegeaddresses.OrderBy(x => x.Id).AsNoTracking().ToListAsync();
        }

        public async Task<Collegeaddress> NewData(Collegeaddress source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Collegeaddresses.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Collegeaddress source)
        {
            Update(source);
        }
    }
}
