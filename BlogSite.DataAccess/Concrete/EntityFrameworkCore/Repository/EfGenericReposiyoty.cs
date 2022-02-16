using BlogSite.DataAccess.Concrete.EntityFrameworkCore.Context;
using BlogSite.DataAccess.Intefaces;
using BlogSite.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlogSite.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfGenericReposiyoty<TEntity> : IGenericDal<TEntity> where TEntity : class, ITable, new()
    {

        public async Task AddAsync(TEntity entity)
        {
            using var context = new BlogSiteContext();
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using var context = new BlogSiteContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using var context = new BlogSiteContext();
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            using var context = new BlogSiteContext();
            return await context.Set<TEntity>().ToListAsync();
        }

      

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new BlogSiteContext();
            return await context.Set<TEntity>().Where(filter).ToListAsync();
        }


        public async Task<List<TEntity>> GetAllAsync<Tkey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, Tkey>> keyselector)
        {
            using var context = new BlogSiteContext();
            return await context.Set<TEntity>().Where(filter).OrderByDescending(keyselector).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> keyselector)
        {
            using var context = new BlogSiteContext();
            return await context.Set<TEntity>().OrderByDescending(keyselector).ToListAsync();
        }

        public  async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new BlogSiteContext();
            return await context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        
    }
}
