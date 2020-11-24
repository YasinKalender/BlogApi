using MyBlog.Business.Abstract;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Concrete
{
    public class CategoryManager : BaseManager<Category>, ICategoryService
    {

        private IBaseRepository<Category> _baseRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(IBaseRepository<Category> baseRepository, ICategoryRepository categoryRepository) : base(baseRepository)
        {
            _baseRepository = baseRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<List<Category>> WithBlog()
        {
           return await _categoryRepository.WithBlog();
        }
    }
}
