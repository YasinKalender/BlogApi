using MyBlog.DTO.DTO.CategoryDtos;
using MyBlog.DTO.DTO.CommentsDto;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.ApiService.Abstract
{
    public interface IBlogApiService
    {

        Task<List<BlogListModel>> GetAll();

        Task<BlogListModel> GetOneBlog(int id);

        Task<List<BlogListModel>> GetAllCategory(int? id);
        Task CreateBlog(BlogsAddModel model);

        Task UpdateBlog(BlogUpdate model);

        Task DeleteBlog(int id);

        Task<List<CommentsDto>> GetComments(int id, int? parentid);

        Task AddComment(CommentsAddDto comment);

        Task<List<CategoryListDto>> Category(int id);

        Task<List<Blog>> FiveBlog();

        Task AddCategoryBlog(CategoryBlog categoryBlog);
        Task RemoveCategoryBlogs(CategoryBlog categoryBlog);

        Task<List<BlogListModel>> BlogSearch(string s);

    }
}
