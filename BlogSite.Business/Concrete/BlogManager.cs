using BlogSite.Business.Interfaces;
using BlogSite.DataAccess.Intefaces;
using BlogSite.Entities;

namespace BlogSite.Business.Concrete
{
    public class BlogManager : GenericManager<Blog>, IBlogService
    {
        private readonly IGenericDal<Blog> _genericDal;
        public BlogManager(IGenericDal<Blog> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<List<Blog>> GetAllSortedByPostedTimeAsync()
        {
            return await _genericDal.GetAllAsync(x => x.PostedTime);
        }
    }
}
