using Microsoft.EntityFrameworkCore;
using MyBlog.DAL.Context;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repository.Concrete
{
    public class CategoryRepository:BaseRepository<Category>,ICategoryRepository
    {

        private readonly ProjectContext _projectContext;
        public CategoryRepository(ProjectContext projectContext):base(projectContext)
        {
            _projectContext = projectContext;
        }

        public async Task<List<Category>> WithBlog()
        {
            return await _projectContext.Categories.Include(i => i.CategoryBlogs).ToListAsync();

           
        }

       
    }
}
