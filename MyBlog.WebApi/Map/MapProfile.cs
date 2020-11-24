using AutoMapper;
using MyBlog.DTO.DTO.CategoryDtos;
using MyBlog.DTO.DTO.CommentsDto;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.WebApi.Map
{
    public class MapProfile:Profile
    {

        public MapProfile()
        {
            CreateMap<Blog, BlogAddModel>();
            CreateMap<BlogAddModel, Blog>();

            CreateMap<Blog, BlogUpdateModel>();
            CreateMap<BlogUpdateModel, Blog>();

            CreateMap<Category, CategoryAddUpdateDto>();
            CreateMap<CategoryAddUpdateDto, Category>();

            CreateMap<Category, CategoryListDto>();
            CreateMap<CategoryListDto, Category>();

            CreateMap<Comment, CommentsDto>();
            CreateMap<CommentsDto, Comment>();


           
        }

    }
}
