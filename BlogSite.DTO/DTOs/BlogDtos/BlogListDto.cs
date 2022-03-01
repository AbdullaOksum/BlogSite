using BlogSite.DTO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DTO.DTOs.BlogDtos
{
    public class BlogListDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime PostedTime { get; set; }
    }
}
