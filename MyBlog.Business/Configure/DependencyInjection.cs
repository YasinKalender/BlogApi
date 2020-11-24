using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Business.Abstract;
using MyBlog.Business.Concrete;
using MyBlog.Business.Validation;
using MyBlog.DAL.Context;
using MyBlog.DTO.DTO.AppUserDtos;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.Repository.Abstract;
using MyBlog.Repository.Concrete;
using MyBlog.Tools.JwtTool;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace MyBlog.Business.Configure
{
    public static class DependencyInjection
    {

       
        public static void ConfigureService(this IServiceCollection services)
        {
            services.AddDbContext<ProjectContext>();
            
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IBaseService<>), typeof(BaseManager<>));




            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IBlogService, BlogManager>();




            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ICommentService, CommentManager>();

            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();


            services.AddScoped<IJwtService, JwtManager>();

            services.AddTransient<IValidator<AppUserDto>, AppUserValidatior>();

            services.AddScoped<INlogAdapter, NlogAdapter>();



        }

    }
}
