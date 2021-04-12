using ITMCollegeService.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ITMCollegeService.Repositories
{
    public interface IRepositoryBase<T>
    {
        public IQueryable<T> FindAll();

        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly ITMCollegeContext _itmCollegeContext;
        public RepositoryBase(ITMCollegeContext itmCollegeContext)
        {
            _itmCollegeContext = itmCollegeContext;
        }
        public async void Create(T entity)
        {
            await _itmCollegeContext.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _itmCollegeContext.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _itmCollegeContext.Set<T>().Update(entity);
        }

        public IQueryable<T> FindAll()
        {
            return _itmCollegeContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _itmCollegeContext.Set<T>().Where(expression).AsNoTracking();
        }
        public async Task SaveAsync()
        {
            await _itmCollegeContext.SaveChangesAsync();
        }
    }
}
