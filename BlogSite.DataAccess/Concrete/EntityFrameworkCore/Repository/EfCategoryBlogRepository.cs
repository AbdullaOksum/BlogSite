using BlogSite.DataAccess.Intefaces;
using BlogSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfCategoryBlogRepository : EfGenericReposiyoty<CategoryBlog>, ICategoryBlogDal
    {
    }
}
