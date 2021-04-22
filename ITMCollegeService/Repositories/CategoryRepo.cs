using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface ICategoryRepo
    {
        Task<IEnumerable<Category>> GetDatas();
        Task<Category> GetDataByIdAsync(int id);
        Task<Category> NewData(Category source);
        void UpdateData(Category source);
        Task<bool> DeleteData(Category entity);
        Task<IEnumerable<Category>> GetCategoriesByIsHeader(int isHeader);
    }
    public class CategoryRepo : RepositoryBase<Category>, ICategoryRepo
    {
        public CategoryRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
        public async Task<bool> DeleteData(Category entity)
        {
            _itmCollegeContext.Categories.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<Category> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Category>> GetDatas()
        {
            return await _itmCollegeContext.Categories.OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }

        public async Task<Category> NewData(Category source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.Categories.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(Category source)
        {
            Update(source);
        }

        public async Task<IEnumerable<Category>> GetCategoriesByIsHeader(int isHeader)
        {
            return await _itmCollegeContext.Categories.Where(item => item.IsOnHeader == isHeader).OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }
    }
}
