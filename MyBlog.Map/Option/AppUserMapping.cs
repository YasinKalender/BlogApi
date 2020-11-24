using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Map.Option
{
    public class AppUserMapping:BaseMapping<AppUser>
    {

        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(i => i.Name).HasMaxLength(100).IsRequired();
            builder.Property(i => i.Lastname).HasMaxLength(100).IsRequired();
            builder.Property(i => i.Password).HasMaxLength(20).IsRequired();
            builder.Property(i => i.Username).HasMaxLength(30).IsRequired();

            builder.HasMany(i => i.Blogs)
                .WithOne(i => i.AppUser)
                .HasForeignKey(i => i.AppUserID);

            base.Configure(builder);
        }
    }
}
