using BlogSite.Business.Interfaces;
using BlogSite.DataAccess.Intefaces;
using BlogSite.Entities;

namespace BlogSite.Business.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        private readonly IGenericDal<Category> _genericDal;
        public CategoryManager(IGenericDal<Category> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<List<Category>> GetAllSortedByIdAsync()
        {
         return await _genericDal.GetAllAsync(x => x.Id);   
        }
    }
}
