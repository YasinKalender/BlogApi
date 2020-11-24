using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Map.Option
{
    public class CategoryMap:BaseMapping<Category>
    {

        public override void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.Property(i => i.CategoryName).IsRequired();
            builder.HasMany(i => i.CategoryBlogs)
                .WithOne(i => i.Category)
                .HasForeignKey(i => i.CategoryID)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);

            base.Configure(builder);
        }
    }
}
