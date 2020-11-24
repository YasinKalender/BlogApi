using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Map.Option
{
    public class BlogMapping:BaseMapping<Blog>
    {

        public override void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(i => i.ContentTitle).IsRequired();
            builder.Property(i => i.Image).IsRequired(false);
            builder.Property(i => i.Title).HasMaxLength(100).IsRequired();
            builder.Property(i => i.ShortTitle).IsRequired();

            builder.HasMany(i => i.CategoryBlogs)
                .WithOne(i => i.Blog)
                .HasForeignKey(i => i.BlogID)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);

            builder.HasMany(i => i.Comments)
                .WithOne(i => i.Blog)
                .HasForeignKey(i => i.BlogID)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);


            base.Configure(builder);
        }
    }
}
