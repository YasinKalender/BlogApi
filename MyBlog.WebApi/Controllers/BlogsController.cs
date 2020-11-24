using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.DTO.DTO.CategoryDtos;
using MyBlog.DTO.DTO.CommentsDto;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.WebApi.CustomFilter;
using MyBlog.WebApi.Models;

namespace MyBlog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : BaseController
    {

        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        private readonly ICommentService _commentService;

        public BlogsController(IBlogService blogService, IMapper mapper, ICommentService commentService)
        {
            _blogService = blogService;
            _mapper = mapper;
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {


            return Ok(await _blogService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Blogid(int id)
        {

            return Ok(await _blogService.Getbyid(id));
        }

        [HttpPost]

        [ValidModel]
        public async Task<IActionResult> CreateBlog([FromForm] BlogAddModel model)
        {
            var uploadimage = await UploadImage(model.Images, "image/jpeg");

            if (uploadimage.UploadStatus == Models.Enum.UploadStatus.Success)
            {
                model.Image = uploadimage.Name;
                await _blogService.Add(_mapper.Map<Blog>(model));
            }

            else if (uploadimage.UploadStatus == Models.Enum.UploadStatus.NotExsit)
            {
                await _blogService.Add(_mapper.Map<Blog>(model));
            }

            else
            {
                return BadRequest(uploadimage.ErrorMessage);
            }

            return Created("", model);
        }

        [HttpPut("{id}")]

        [ValidModel]
        public async Task<IActionResult> UpdateBlog(int id, [FromForm] BlogUpdateModel model)
        {

            if (id != model.ID)
            {
                return BadRequest();
            }


            var imageupload = await UploadImage(model.Images, "image/jpeg");

            if (imageupload.UploadStatus == Models.Enum.UploadStatus.Success)
            {
                var updatedblog = await _blogService.Getbyid(model.ID);
                updatedblog.Image = model.Image;
                updatedblog.ShortTitle = model.ShortTitle;
                updatedblog.Title = model.Title;
                updatedblog.ContentTitle = model.ContentTitle;
                updatedblog.Image = imageupload.Name;
                await _blogService.Update(updatedblog);
                return NoContent();
            }

            else if (imageupload.UploadStatus == Models.Enum.UploadStatus.NotExsit)
            {
                var updatedblog = await _blogService.Getbyid(model.ID);
                updatedblog.Image = model.Image;
                updatedblog.ShortTitle = model.ShortTitle;
                updatedblog.Title = model.Title;
                updatedblog.ContentTitle = model.ContentTitle;
                await _blogService.Update(updatedblog);
                return NoContent();

            }

            else
            {
                return BadRequest(imageupload.ErrorMessage);
            }




        }

        [HttpDelete("{id}")]

        [ValidModel]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _blogService.Delete(await _blogService.Getbyid(id));

            return NoContent();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddCategoryBlog(CategoryBlog categoryBlog)
        {
            await _blogService.AddCategory(categoryBlog);
            return Created("", categoryBlog);


        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RemoveCategoryBlogs(CategoryBlog categoryBlog)
        {
            await _blogService.RemoveCategory(categoryBlog);
            return NoContent();


        }

        [HttpGet("[action]/{id}")]

        public async Task<IActionResult> GetAllCategory(int? id)
        {


            return Ok(await _blogService.GetAllCategory(id));
        }

        [HttpGet("[action]/{id}")]

        public async Task<IActionResult> Category(int id)
        {



            return Ok(await _blogService.Category(id));
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> FiveBlog()
        {



            return Ok(await _blogService.LastFiveBlog());
        }

        [HttpGet("{id}/[action]")]
        public async Task<IActionResult> GetComments([FromRoute] int id, [FromQuery] int? parentid)

        {



            return Ok(_mapper.Map<List<Comment>>(await _commentService.WithBlogComments(id, parentid)));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> BlogSearch([FromQuery]string s)
        {


            return Ok(await _blogService.Search(s));
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> AddComment(CommentsDto model)
        {

            model.AddDate = DateTime.Now;
            await _commentService.Add(_mapper.Map<Comment>(model));

            return Created("", model);
        }


    }
}
