using ITMCollegeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface ICategoryNewsRepo
    {
        Task<IEnumerable<CategoryNews>> GetDatas();
        Task<CategoryNews> GetDataByIdAsync(int id);
        Task<CategoryNews> NewData(CategoryNews source);
        void UpdateData(CategoryNews source);
        Task<bool> DeleteData(CategoryNews entity);
        Task<bool> ClearCategoryNewsById(int newsId);
    }
    public class CategoryNewsRepo : RepositoryBase<CategoryNews>, ICategoryNewsRepo
    {
        public CategoryNewsRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
        public async Task<bool> DeleteData(CategoryNews entity)
        {
            _itmCollegeContext.CategoryNews.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<CategoryNews> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CategoryNews>> GetDatas()
        {
            return await _itmCollegeContext.CategoryNews.OrderBy(x => x.Id).AsNoTracking().ToListAsync();
        }

        public async Task<CategoryNews> NewData(CategoryNews source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.CategoryNews.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public async Task<bool> ClearCategoryNewsById (int newsId)
        {
            var entities = await _itmCollegeContext.CategoryNews.Where(item => item.NewsId == newsId).ToListAsync();
            _itmCollegeContext.CategoryNews.RemoveRange(entities);
            await SaveAsync();
            return true;
        }

        public void UpdateData(CategoryNews source)
        {
            Update(source);
        }
    }
}
