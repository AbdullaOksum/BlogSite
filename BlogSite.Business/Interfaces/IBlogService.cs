using BlogSite.Entities;

namespace BlogSite.Business.Interfaces
{
    public interface IBlogService : IGenericService<Blog>
    {
        Task<List<Blog>> GetAllSortedByPostedTimeAsync();
    }
}
