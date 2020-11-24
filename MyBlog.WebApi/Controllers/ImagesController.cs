using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;

namespace MyBlog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public ImagesController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> BlogImage(int id)
        {

          var blogs =  await _blogService.Getbyid(id);

            if (string.IsNullOrWhiteSpace(blogs.Image))
            {
                return NotFound();
            }


            return File($"/img/{blogs.Image}","image/jpeg");
        }
    }
}
