using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.DTO.DTO.CommentsDto;
using MyBlog.Repository.Abstract;
using MyBlog.UI.ApiService.Abstract;

namespace MyBlog.UI.Controllers
{
    public class HomeController : Controller
    {

        IBlogApiService _blogApiService;

        public HomeController(IBlogApiService blogApiService)
        {
            _blogApiService = blogApiService;
        }

        public async Task<IActionResult> Index(int? categoryid,string s)
        {
            if (categoryid.HasValue)
            {
                ViewBag.active = categoryid;
                return View(await _blogApiService.GetAllCategory((int)categoryid));
            }

            if (!string.IsNullOrWhiteSpace(s))
            {
                ViewBag.search = s;
                return View(await _blogApiService.BlogSearch(s));
            }

            return View(await _blogApiService.GetAll());
        }

        public async Task<IActionResult> BlogDetails(int id)
        {
            ViewBag.comment = await _blogApiService.GetComments(id, null);

            return View(await _blogApiService.GetOneBlog(id));
        }

        public async Task<IActionResult> AddComment(CommentsAddDto comment)
        {
            await _blogApiService.AddComment(comment);

            return RedirectToAction("BlogDetails", new { id = comment.BlogID });


        }
    }
}
