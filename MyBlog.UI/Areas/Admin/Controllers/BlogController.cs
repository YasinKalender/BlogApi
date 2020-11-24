using Microsoft.AspNetCore.Mvc;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.UI.ApiService.Abstract;
using MyBlog.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly IBlogApiService _blogApiService;
        private readonly ICategoryApiService _categoryApiService;

        public BlogController(IBlogApiService blogApiService, ICategoryApiService categoryApiService)
        {
            _blogApiService = blogApiService;
            _categoryApiService = categoryApiService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _blogApiService.GetAll());
        }


        public IActionResult CreateBlog()
        {

            return View(new BlogsAddModel());
        }


        [HttpPost]
        public async Task<IActionResult> CreateBlog(BlogsAddModel model)
        {
            if (ModelState.IsValid)
            {
                await _blogApiService.CreateBlog(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }


        public async Task<IActionResult> UpdateBlog(int id)
        {
            var blog = await _blogApiService.GetOneBlog(id);



            return View(new BlogUpdate() { 
            ID=blog.ID,
            ContentTitle=blog.ContentTitle,
            ShortTitle=blog.ShortTitle,
            Title=blog.Title
            
            });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBlog(BlogUpdate model)
        {
            if (ModelState.IsValid)
            {
                model.AppUserID = 1;
                await _blogApiService.UpdateBlog(model);
                return RedirectToAction("Index");
            }


            return View(model);
        }

        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _blogApiService.DeleteBlog(id);

            return RedirectToAction("Index");


        }

        public async Task<IActionResult> AssignCategory(int id)
        {
            var category =await _categoryApiService.GetAll();
            var blog = (await _blogApiService.GetAllCategory(id)).Select(i=>i.Title).ToList();
            TempData["BlogID"] = id;

            List<CategoryModel> categorymodel = new List<CategoryModel>();

            foreach (var item in categorymodel)
            {
                CategoryModel model = new CategoryModel();
                model.CategoryID = item.CategoryID;
                model.CategoryName = item.CategoryName;
                model.Exist = blog.Contains(item.CategoryName);
               

                categorymodel.Add(model);

            }

            return View(categorymodel);
        }

        [HttpPost]
        public async Task<IActionResult> AssignCategory(List<CategoryModel> model)
        {

            int id = (int)TempData["BlogID"];
            foreach (var item in model)
            {
                if (item.Exist)
                {
                    CategoryBlog categoryBlog = new CategoryBlog();
                    categoryBlog.BlogID = id;
                    categoryBlog.CategoryID = item.CategoryID;
                    await _blogApiService.AddCategoryBlog(categoryBlog);
                }

                else
                {
                    CategoryBlog categoryBlog = new CategoryBlog();
                    categoryBlog.BlogID = id;
                    categoryBlog.CategoryID = item.CategoryID;
                    await _blogApiService.RemoveCategoryBlogs(categoryBlog);
                }
            }

            return RedirectToAction("Index");

          


        }

    }
}
