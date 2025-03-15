using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IGenaricRepository<T> where T : class
    {
        //Add
        public Task AddAsync(T entity);
        public Task UpdateAsync(T entity);
        public Task DeleteAsync(T entity);
        public Task AddRangeAsync(List<T> entitys);
        public Task DeleteRangeAsync(List<T> entity);
        public Task<List<T>> GetAllWithNotTrackingAsync();
        public Task<T> FindOneAsync(Expression<Func<T, bool>> match);
        public Task<T> FindOneWithNotTracingAsync(Expression<Func<T, bool>> match);
        public Task<List<T>> FindMoreAsync(Expression<Func<T, bool>> match);
        public Task<List<T>> FindMoreWithNotTracingAsync(Expression<Func<T, bool>> match);
        public IQueryable<T> GetQueryable();
        public Task<bool> IsExist(Expression<Func<T, bool>> match);


    }
}
