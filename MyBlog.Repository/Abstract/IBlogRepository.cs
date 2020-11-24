using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repository.Abstract
{
    public interface IBlogRepository:IBaseRepository<Blog>
    {

        Task<List<Blog>> GetAllCategory(int? categoryid);
        Task<List<Category>> Category(int id);

        Task<List<Blog>> LastFiveBlog();
    }
}
