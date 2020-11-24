using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repository.Abstract
{
    public interface ICommentRepository:IBaseRepository<Comment>
    {

        Task<List<Comment>> WithBlogComments(int blogid, int? parentid);
    }
}
