using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Abstract
{
    public interface ICommentService : IBaseService<Comment>
    {

        Task<List<Comment>> WithBlogComments(int blogid, int? parentid);
    }
}
