using MyBlog.DTO.DTO.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.ApiService.Abstract
{
    public interface ICategoryApiService
    {
        Task<List<CategoryListDto>> GetAll();

        Task<List<CategoryListDto>> CountBlog();

        Task<CategoryListDto> GetByName(int id);

        Task CreateCategory(CategoryAddUpdateDto model);

        Task UpdateCategory(CategoryAddUpdateDto model);

        Task DeleteCategory(int id);

    }
}
