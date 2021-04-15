using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface IDepartmentRepo
    {
        Task<IEnumerable<Department>> GetDatas();
        Task<Department> GetDataByIdAsync(int id);
        Task<Department> NewData(Department source);
        void UpdateData(Department source);
        Task<bool> DeleteData(Department entity);
    }
    public class DepartmentRepo : RepositoryBase<Department>, IDepartmentRepo
    {
        public DepartmentRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
        public async Task<bool> DeleteData(Department entity)
        {
            _itmCollegeContext.Departments.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<Department> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Department>> GetDatas()
        {
            return await _itmCollegeContext.Departments.OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }

        public async Task<Department> NewData(Department source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Departments.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Department source)
        {
            Update(source);
        }
    }
}
