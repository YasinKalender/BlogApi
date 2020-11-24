using Microsoft.AspNetCore.Mvc;
using MyBlog.UI.ApiService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.Components
{
    public class Search:ViewComponent
    {

        private IBlogApiService _blogApiService;

        public Search(IBlogApiService blogApiService)
        {
            _blogApiService = blogApiService;
        }

        public IViewComponentResult Invoke(string s)
        {
            ViewBag.search = s;

            return View();
        }
    }
}
