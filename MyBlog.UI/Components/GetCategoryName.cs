using Microsoft.AspNetCore.Mvc;
using MyBlog.UI.ApiService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.Components
{
    public class GetCategoryName:ViewComponent
    {

        private readonly ICategoryApiService _categoryApiService;

        public GetCategoryName(ICategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }



        public IViewComponentResult Invoke(int categoryid)
        {
            
           

            return View(_categoryApiService.GetByName(categoryid).Result);
        }
    }
}
