using BlogSite.Business.Interfaces;
using BlogSite.DataAccess.Intefaces;
using BlogSite.Entities;

namespace BlogSite.Business.Concrete
{
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {
       private readonly IGenericDal<AppUser> _genericDal;
        public AppUserManager(IGenericDal<AppUser> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}
