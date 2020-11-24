using Microsoft.AspNetCore.Mvc;
using MyBlog.UI.ApiService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.Components
{
    public class CategoryList:ViewComponent
    {

        private ICategoryApiService _categoryApiService;

        public CategoryList(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }
        public IViewComponentResult Invoke()
        {
            

            return View(_categoryApiService.CountBlog().Result);
        }

    }
}
