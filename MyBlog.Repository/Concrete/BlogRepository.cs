using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
    public class BlogRepository : BaseRepository<Blog>, IBlogRepository
    {
        private readonly ProjectContext _projectContext;
        public BlogRepository(ProjectContext projectContext):base(projectContext)
        {
            _projectContext = projectContext;
        }

        public async Task<List<Blog>> GetAllCategory(int? categoryid)
        {
           return await _projectContext.Blogs.Join(_projectContext.CategoryBlogs, b => b.ID, cb => cb.BlogID, (blog, categoryblog) => new
            {
                blog = blog,
                categoryblog = categoryblog


            }).Where(i=>i.categoryblog.CategoryID==categoryid).Select(i=>new Blog() { 
            
            AppUserID=i.blog.AppUserID,
            AppUser=i.blog.AppUser,
            CategoryBlogs=i.blog.CategoryBlogs,
            Comments=i.blog.Comments,
            ContentTitle=i.blog.ContentTitle,
            ID=i.blog.ID,
            Image=i.blog.Image,
            ShortTitle=i.blog.ShortTitle,
            Title=i.blog.Title,
            
            }).ToListAsync();
        }

        public async Task<List<Category>> Category(int id)
        {
            return await _projectContext.Categories.Join(_projectContext.CategoryBlogs, c => c.ID, cb => cb.CategoryID, (category, categoryblog) => new
            {
                category=category,
                categoryblog=categoryblog


            }).Where(i=>i.categoryblog.BlogID==id).Select(i=>new Category() { 
            
            CategoryName=i.category.CategoryName,
            ID=i.category.ID,
            
            
            }).ToListAsync();


        }


        
        public async Task<List<Blog>> LastFiveBlog()
        {

            return await _projectContext.Blogs.OrderByDescending(i => i.AddDate).Take(5).ToListAsync();
        }
    }
}
