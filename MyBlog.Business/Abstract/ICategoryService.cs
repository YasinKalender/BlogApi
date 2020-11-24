using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Abstract
{
    public interface ICategoryService : IBaseService<Category>
    {

        Task<List<Category>> WithBlog();
    }
}
