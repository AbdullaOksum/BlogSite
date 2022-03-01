using AutoMapper;
using BlogSite.Business.Interfaces;
using BlogSite.DTO.DTOs.BlogDtos;
using BlogSite.Entities;
using BlogSite.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        public BlogsController(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Ok(_mapper.Map<List<BlogListDto>> (await _blogService.GetAllSortedByPostedTimeAsync()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<BlogListDto>( await _blogService.FindByIdAsync(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(BlogAddModel blogAddModel)
        {
            await _blogService.AddAsync(_mapper.Map<Blog>(blogAddModel));
            return Created("", blogAddModel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, BlogUpdateModel blogUpdateModel)
        {
            if (id != blogUpdateModel.Id)
            {
                return BadRequest("Denne id findes ikke");
            }
            await _blogService.UpdateAsync(_mapper.Map<Blog>(blogUpdateModel));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _blogService.DeleteAsync(new Blog { Id = id });
            return NoContent();
        }
    }
}
