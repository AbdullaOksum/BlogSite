using BlogSite.DTO.Interface;

namespace BlogSite.DTO.DTOs.CategoryDtos
{
    public class CategoryUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
