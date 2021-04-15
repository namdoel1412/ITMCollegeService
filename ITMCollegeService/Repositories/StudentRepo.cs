using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface IStudentRepo
    {
        Task<IEnumerable<Student>> GetDatas();
        Task<Student> GetDataByIdAsync(int id);
        Task<Student> NewData(Student source);
        void UpdateData(Student source);
        Task<bool> DeleteData(Student entity);
    }
    public class StudentRepo : RepositoryBase<Student>, IStudentRepo
    {
        public StudentRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
        public async Task<bool> DeleteData(Student entity)
        {
            _itmCollegeContext.Students.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<Student> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Student>> GetDatas()
        {
            return await _itmCollegeContext.Students.OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }

        public async Task<Student> NewData(Student source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Students.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Student source)
        {
            Update(source);
        }
    }
}
