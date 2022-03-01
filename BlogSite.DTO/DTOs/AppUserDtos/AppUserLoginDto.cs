using BlogSite.DTO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DTO.DTOs.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
