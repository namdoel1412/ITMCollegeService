using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface ICourseRepo
    {
        Task<IEnumerable<Course>> GetDatas();
        Task<Course> GetDataByIdAsync(int id);
        Task<Course> NewData(Course source);
        void UpdateData(Course source);
        Task<bool> DeleteData(Course entity);
    }
    public class CourseRepo : RepositoryBase<Course>, ICourseRepo
    {
        public CourseRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
        public async Task<bool> DeleteData(Course entity)
        {
            _itmCollegeContext.Courses.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<Course> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Course>> GetDatas()
        {
            return await _itmCollegeContext.Courses.OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }

        public async Task<Course> NewData(Course source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Courses.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Course source)
        {
            Update(source);
        }
    }
}
