using Microsoft.AspNetCore.Mvc;
using MyBlog.DTO.DTO.AppUserDtos;
using MyBlog.UI.ApiService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.Controllers
{
    public class AccountController : Controller
    {

        private readonly IAutApiService _autApiService;

        public AccountController(IAutApiService autApiService)
        {
            _autApiService = autApiService;
        }
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async  Task<IActionResult> Login(AppUserDto model)
        {
            if (await _autApiService.Login(model))
            {
                return RedirectToAction("");
            }

            return View();
        }
    }
}
