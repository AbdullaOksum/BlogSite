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
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        private readonly IGenericDal<Category> _genericDal;
        public CategoryManager(IGenericDal<Category> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}
