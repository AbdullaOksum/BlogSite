using BlogSite.Business.Interfaces;
using BlogSite.DataAccess.Intefaces;
using BlogSite.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Business.Concrete
{

    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        private readonly IGenericDal<TEntity> _generiService;

        public GenericManager(IGenericDal<TEntity> genericService)
        {
            _generiService = genericService;
        }

        public async Task AddAsync(TEntity entity)
        {
           await _generiService.AddAsync(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await _generiService.DeleteAsync(entity);
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
          return await _generiService.FindByIdAsync(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _generiService.GetAllAsync();
        }

       

        public async Task UpdateAsync(TEntity entity)
        {
         await _generiService.UpdateAsync(entity);
        }
    }
}
