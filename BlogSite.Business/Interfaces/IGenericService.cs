using BlogSite.Entities.Interfaces;
using System.Linq.Expressions;

namespace BlogSite.Business.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> FindByIdAsync(int id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
