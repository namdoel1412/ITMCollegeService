using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface IFacultyRepo
    {
        Task<IEnumerable<Faculty>> GetDatas();
        Task<Faculty> GetDataByIdAsync(int id);
        Task<Faculty> NewData(Faculty source);
        void UpdateData(Faculty source);
        Task<bool> DeleteData(Faculty entity);
    }
    public class FacultyRepo : RepositoryBase<Faculty>, IFacultyRepo
    {
        public FacultyRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
        public async Task<bool> DeleteData(Faculty entity)
        {
            _itmCollegeContext.Faculties.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<Faculty> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Faculty>> GetDatas()
        {
            return await _itmCollegeContext.Faculties.OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }

        public async Task<Faculty> NewData(Faculty source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Faculties.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Faculty source)
        {
            Update(source);
        }
    }
}
