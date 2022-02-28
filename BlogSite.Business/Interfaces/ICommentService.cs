using BlogSite.DataAccess.Intefaces;
using BlogSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Business.Interfaces
{
    public interface ICommentService : IGenericService<Comment>
    {
    }
}
