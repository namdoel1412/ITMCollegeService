using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;

namespace ITMCollegeService.Repositories
{
    public interface INewsRepo
    {
        Task<IEnumerable<News>> GetDatas();
        Task<News> GetDataByIdAsync(int id);
        Task<News> NewData(News source);
        void UpdateData(News source);
        Task<bool> DeleteData(News entity);
        Task<IEnumerable<News>> GetNewsByCategoryId(int categoryId);
        Task<IEnumerable<News>> GetNewsByIsBanner(int isBanner);
    }
    public class NewsRepo : RepositoryBase<News>, INewsRepo
    {
        public NewsRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }

        public async Task<bool> DeleteData(News entity)
        {
            _itmCollegeContext.News.Remove(entity);
            await SaveAsync();
            return true;
        }

        public async Task<News> GetDataByIdAsync(int id)
        {
            return await FindByCondition(item => item.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<News>> GetDatas()
        {
            return await _itmCollegeContext.News.OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }

        public async Task<News> NewData(News source)
        {
            Create(source);
            await SaveAsync();
            var entity = await _itmCollegeContext.News.OrderByDescending(item => item.Id).FirstOrDefaultAsync();
            return entity;
        }

        public void UpdateData(News source)
        {
            Update(source);
        }

        public async Task<IEnumerable<News>> GetNewsByCategoryId(int categoryId)
        {
            var entity = await _itmCollegeContext.CategoryNews.Where(item => item.CategoryId == categoryId).ToListAsync();
            IList<News> result = new List<News>();
            foreach(var item in entity)
            {
                var tmp = await GetDataByIdAsync(item.NewsId);
                if(tmp != null) result.Add(tmp);
            }
            return result;
        }

        public async Task<IEnumerable<News>> GetNewsByIsBanner(int isBanner)
        {
            return await _itmCollegeContext.News.Where(item => item.IsBanner == isBanner).OrderBy(x => x.Name).AsNoTracking().ToListAsync();
        }
    }
}
