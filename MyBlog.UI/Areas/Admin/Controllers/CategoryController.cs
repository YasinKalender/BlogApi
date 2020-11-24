using Microsoft.AspNetCore.Mvc;
using MyBlog.DTO.DTO.CategoryDtos;
using MyBlog.UI.ApiService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryApiService _categoryApiService;

        public CategoryController(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _categoryApiService.GetAll());
        }

        public IActionResult CreateCategory()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryAddUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                await _categoryApiService.CreateCategory(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> CategoryUpdate(int id)
        {
            var category = await _categoryApiService.GetByName(id);

            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> CategoryUpdate(CategoryAddUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                await _categoryApiService.UpdateCategory(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryApiService.DeleteCategory(id);

            return RedirectToAction("Index");
        }

    }
}
