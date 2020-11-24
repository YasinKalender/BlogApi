using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repository.Abstract
{
    public interface ICategoryRepository:IBaseRepository<Category>
    {

        Task<List<Category>> WithBlog();

   
    }
}
