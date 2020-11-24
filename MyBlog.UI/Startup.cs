using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyBlog.Business.Abstract;
using MyBlog.Business.Concrete;
using MyBlog.Business.Configure;
using MyBlog.Repository.Abstract;
using MyBlog.Repository.Concrete;
using MyBlog.UI.ApiService.Abstract;
using MyBlog.UI.ApiService.Concrete;

namespace MyBlog.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddHttpContextAccessor();
            services.AddHttpClient<IBlogApiService, BlogApiManager>();
            services.AddHttpClient<ICategoryApiService, CategoryApiManager>();
            services.AddHttpClient<IImageApiSerive, ImageApiManager>();
            services.AddHttpClient<IAutApiService, AutApiManager>();

            services.AddControllersWithViews();

            services.ConfigureService();

           

          


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           

            app.UseRouting();
            app.UseStaticFiles();
            app.UseSession();
            

            app.UseEndpoints(endpoints =>
            {
              

                endpoints.MapControllerRoute(
                    name:"areas",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"


                    );

                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}"


                   );
            });

            
        }
    }
}
