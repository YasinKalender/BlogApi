using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Map.Option
{
    public class CommentMap:BaseMapping<Comment>
    {

        public override void Configure(EntityTypeBuilder<Comment> builder)
        {

            builder.Property(i => i.Comments).IsRequired(false);
            builder.Property(i => i.AuthorName).IsRequired();
            builder.Property(i => i.Email).IsRequired();

            builder.HasOne(i => i.ParentComment)
                .WithMany(i => i.SubComments)
                .HasForeignKey(i => i.ParentCommentID);

            


            

            base.Configure(builder);
        }
    }
}
