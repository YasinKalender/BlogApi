using Microsoft.EntityFrameworkCore;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.Map.Option;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.DAL.Context
{
    public class ProjectContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=MyBlogs; integrated security=true");

            base.OnConfiguring(optionsBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new AppUserMapping());
        //    modelBuilder.ApplyConfiguration(new BlogMapping());
        //    modelBuilder.ApplyConfiguration(new CategoryBlogMap());
        //    modelBuilder.ApplyConfiguration(new CategoryMap());
        //    modelBuilder.ApplyConfiguration(new CommentMap());


        //    base.OnModelCreating(modelBuilder);
        //}

        public DbSet<AppUser> AppUser { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<CategoryBlog> CategoryBlogs { get; set; }

       

    }
}
