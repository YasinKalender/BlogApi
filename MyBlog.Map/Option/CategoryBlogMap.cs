using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Map.Option
{
    public class CategoryBlogMap:BaseMapping<CategoryBlog>
    {
        public override void Configure(EntityTypeBuilder<CategoryBlog> builder)
        {
            builder.HasIndex(i => new { i.BlogID, i.CategoryID }).IsUnique();

            base.Configure(builder);
        }

    }
}
