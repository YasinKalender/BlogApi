using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Abstract
{
    public interface IBlogService : IBaseService<Blog>
    {

        Task AddCategory(CategoryBlog categoryBlog);
        Task RemoveCategory(CategoryBlog categoryBlog);
        
        Task<List<Blog>> GetAllCategory(int? categoryid);

        Task<List<Category>> Category(int id);

        Task<List<Blog>> LastFiveBlog();

        Task<List<Blog>> Search(string s);
    }
}
