using BlogSite.Business.Concrete;
using BlogSite.Business.Interfaces;
using BlogSite.DataAccess.Concrete.EntityFrameworkCore.Repository;
using BlogSite.DataAccess.Intefaces;
using Microsoft.Extensions.DependencyInjection;

namespace BlogSite.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericReposiyoty<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
        }
    }
}
