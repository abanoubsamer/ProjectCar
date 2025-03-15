using Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class GenaricRepository<T> : IGenaricRepository<T> where T : class
    {
        #region Failds
        private readonly DbSet<T> _Dbset;
        private readonly ApplicationContext context;
        #endregion


        #region Constractor
        public GenaricRepository(ApplicationContext db)
        {
            context = db;
            _Dbset = db.Set<T>();
        }
        #endregion


        #region Implemntation
        public async Task AddAsync(T entity)
        {
            await _Dbset.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(List<T> entitys)
        {
            await _Dbset.AddRangeAsync(entitys);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _Dbset.Remove(entity);
            await context.SaveChangesAsync(); 


        }

        public async Task DeleteRangeAsync(List<T> entity)
        {
            _Dbset.RemoveRange(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<T>> FindMoreAsync(Expression<Func<T, bool>> match)
        {
            return await _Dbset.Where(match).ToListAsync();
        }

        public async Task<List<T>> FindMoreWithNotTracingAsync(Expression<Func<T, bool>> match)
        {
            return await _Dbset.Where(match).AsNoTracking().ToListAsync();
        }

        public async Task<T> FindOneAsync(Expression<Func<T, bool>> match)
        {
            return await _Dbset.FirstOrDefaultAsync(match); 
        }

        public async Task<T> FindOneWithNotTracingAsync(Expression<Func<T, bool>> match)
        {
            return await _Dbset.AsNoTracking().FirstOrDefaultAsync(match);
        }

        public async Task<List<T>> GetAllWithNotTrackingAsync()
        {
            return await _Dbset.ToListAsync();
        }

        public IQueryable<T> GetQueryable()
        {
            return _Dbset.AsQueryable();
        }

        public async Task<bool> IsExist(Expression<Func<T, bool>> match)
        {
            return await _Dbset.AnyAsync(match);
        }

        public async Task UpdateAsync(T entity)
        {
               _Dbset.Update(entity);
            await context.SaveChangesAsync();   
        }

        #endregion


    }
}
