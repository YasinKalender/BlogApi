using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Map.Option
{
    public class BaseMapping<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(i => i.AddDate).IsRequired();
            builder.Property(i => i.DeleteDate).IsRequired(false);
            builder.Property(i => i.UpdateDate).IsRequired(false);
            builder.Property(i => i.status).IsRequired();
        }
    }
}
