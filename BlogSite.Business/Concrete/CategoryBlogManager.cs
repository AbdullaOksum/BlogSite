using BlogSite.Business.Interfaces;
using BlogSite.DataAccess.Intefaces;
using BlogSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Business.Concrete
{
    public class CategoryBlogManager : GenericManager<CategoryBlog>, ICategoryBlogService
    {
        private readonly IGenericDal<CategoryBlog> _categoryDal;
        public CategoryBlogManager(IGenericDal<CategoryBlog> category) : base(category)
        {
            _categoryDal = category;
        }
    }
}
