using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface ISemesterRepo
    {
        Task<IEnumerable<Semester>> GetDatas();
        Task<Semester> GetDataByIdAsync(int id);
        Task<Semester> NewData(Semester source);
        void UpdateData(Semester source);
        Task<bool> DeleteData(Semester entity);
    }
    public class SemesterRepo : RepositoryBase<Semester>, ISemesterRepo
    {
        public SemesterRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }

        public async Task<bool> DeleteData(Semester entity)
        {
            _itmCollegeContext.Semesters.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<Semester> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Semester>> GetDatas()
        {
            return await _itmCollegeContext.Semesters.OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }

        public async Task<Semester> NewData(Semester source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Semesters.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Semester source)
        {
            Update(source);
        }
    }
}
