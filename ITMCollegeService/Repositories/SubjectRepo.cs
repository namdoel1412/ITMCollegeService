using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface ISubjectRepo
    {
        Task<IEnumerable<Subject>> GetDatas();
        Task<Subject> GetDataByIdAsync(int id);
        Task<Subject> NewData(Subject source);
        void UpdateData(Subject source);
        Task<bool> DeleteData(Subject entity);
    }
    public class SubjectRepo : RepositoryBase<Subject>, ISubjectRepo
    {
        public SubjectRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
        public async Task<bool> DeleteData(Subject entity)
        {
            _itmCollegeContext.Subjects.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<Subject> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Subject>> GetDatas()
        {
            return await _itmCollegeContext.Subjects.OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }

        public async Task<Subject> NewData(Subject source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Subjects.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Subject source)
        {
            Update(source);
        }
    }
}
