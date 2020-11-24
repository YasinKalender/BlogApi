using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.DTO.DTO.AppUserDtos;
using MyBlog.Tools.JwtTool;
using MyBlog.WebApi.CustomFilter;

namespace MyBlog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAppUserService _appUserService;
        private readonly IJwtService _jwtService;

        public AuthController(IAppUserService appUserService, IJwtService jwtService)
        {
            _appUserService = appUserService;
            _jwtService = jwtService;
        }

        [HttpPost("[action]")]
        [ValidModel]
        public async Task<IActionResult> Login(AppUserDto appUserDto)
        {
           var user =  await _appUserService.Login(appUserDto);

            if (user!=null)
            {
                return Created("", _jwtService.Token(user));
            }

            else
            {
                return BadRequest("Kullanıcı adı veya şifre hatalı");
            }


            
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> ActiveUser()
        {
            var user = await _appUserService.GetUser(User.Identity.Name);

            
            
            return Ok(new AppUserActive() {Name=user.Name,Surname=user.Lastname });
        }
    }
}
