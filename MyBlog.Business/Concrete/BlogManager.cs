using MyBlog.Business.Abstract;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Concrete
{
    public class BlogManager : BaseManager<Blog>, IBlogService
    {

        private readonly IBaseRepository<Blog> _baseRepository;
        private readonly IBaseRepository<CategoryBlog> _categoryblogservice;
        private readonly IBlogRepository _blogRepository;

        public BlogManager(IBaseRepository<Blog> baseRepository, IBaseRepository<CategoryBlog> categoryblogservice, IBlogRepository blogRepository) : base(baseRepository)
        {
            _baseRepository = baseRepository;
            _categoryblogservice = categoryblogservice;
            _blogRepository = blogRepository;
        }

        public async Task AddCategory(CategoryBlog categoryBlog)
        {
       

            var control = await _categoryblogservice.Getone(i => i.CategoryID == categoryBlog.CategoryID && i.BlogID == categoryBlog.BlogID);
            if (control==null)
            {
              await _categoryblogservice.Add(new CategoryBlog() { BlogID = categoryBlog.BlogID, CategoryID = categoryBlog.CategoryID });
            }
        }

        public async Task<List<Category>> Category(int id)
        {
            return await _blogRepository.Category(id);
        }

        public async Task<List<Blog>> GetAllCategory(int? categoryid)
        {
           return await _blogRepository.GetAllCategory(categoryid);
        }

        public async Task<List<Blog>> LastFiveBlog()
        {
            return await _blogRepository.LastFiveBlog();
        }

        public async Task RemoveCategory(CategoryBlog categoryBlog)
        {
            var deletedcategory = await _categoryblogservice.Getone(i => i.CategoryID == categoryBlog.CategoryID && i.BlogID == categoryBlog.BlogID);

            if (deletedcategory!=null)
            {
                await _categoryblogservice.Delete(deletedcategory);
            }

            
        }

        public async Task<List<Blog>> Search(string s)
        {
            return await _baseRepository.GetAll(i => i.Title.Contains(s) || i.ShortTitle.Contains(s));
        }
    }
}
