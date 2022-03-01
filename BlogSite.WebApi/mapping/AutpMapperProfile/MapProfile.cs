using AutoMapper;
using BlogSite.DTO.DTOs.BlogDtos;
using BlogSite.DTO.DTOs.CategoryDtos;
using BlogSite.Entities;
using BlogSite.WebApi.Models;

namespace BlogSite.WebApi.mapping.AutpMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<BlogListDto, Blog>();
            CreateMap<Blog, BlogListDto>();

            CreateMap<BlogUpdateModel, Blog>();
            CreateMap<Blog, BlogUpdateModel>();

            CreateMap<BlogAddModel, Blog>();
            CreateMap<Blog, BlogAddModel>();

            CreateMap<CategoryListDto, Category>();
            CreateMap<Category, CategoryListDto>();

            CreateMap<CategoryAddDto, Category>();
            CreateMap<Category, CategoryAddDto>();

            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();


        }
    }
   
}
