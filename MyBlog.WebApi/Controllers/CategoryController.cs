using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Business.Abstract;
using MyBlog.DTO.DTO.CategoryDtos;
using MyBlog.Entities.ORM.Concrete;

namespace MyBlog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IMapper _mapper;
        private ICategoryService _categoryService;
        private INlogAdapter _nlogAdapter;

        public CategoryController(IMapper mapper, ICategoryService categoryService, INlogAdapter nlogAdapter)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _nlogAdapter = nlogAdapter;
        }

        public async Task<IActionResult> CategoryAll()
        {


            return Ok(await _categoryService.GetAll());
        }

        [HttpPost]
    
        public async Task<IActionResult> Create(CategoryAddUpdateDto model)
        {
            if (ModelState.IsValid)
            {
               await _categoryService.Add(_mapper.Map<Category>(model));
            }

            return Created("",model);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> CategoryId(int id)
        {
            

            return Ok(await _categoryService.Getbyid(id));

        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateCategory(int id,CategoryAddUpdateDto model)
        {

            if (id!=model.ID)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {

                var category = await _categoryService.Getbyid(id);
                await _categoryService.Update(_mapper.Map<Category>(category));
            }


            return NoContent();
        }

        [HttpDelete("{id}")]


        public async Task<IActionResult> DeleteCategory(int id)
        {

            await _categoryService.Delete(await _categoryService.Getbyid(id));

            return NoContent();

        }


        [HttpGet("[action]")]
        public async Task<IActionResult> CategoryCount()
        {
           var categories =  await _categoryService.WithBlog();

            List<CategoryListDto> model = new List<CategoryListDto>();

            foreach (var item in categories)
            {
                CategoryListDto dto = new CategoryListDto();
                dto.CategoryName = item.CategoryName;
                dto.CategoryBlogCount = item.CategoryBlogs.Count();

                model.Add(dto);

            }
          

            

            

            return Ok(model);
        }

        [Route("/Error")]

        public IActionResult Error()
        {
            var exceptionHandlerPathFeature =HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            _nlogAdapter.Logla($"Hata yeri:{exceptionHandlerPathFeature.Path} Hata mesajı:{exceptionHandlerPathFeature.Error.Message}");

            return Problem(detail: "Hata oluştu");
        }

    }
}
