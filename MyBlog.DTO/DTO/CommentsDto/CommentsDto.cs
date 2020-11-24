using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.DTO.DTO.CommentsDto
{
    public class CommentsDto:BaseDto
    {
        public string Comments { get; set; }

        public string AuthorName { get; set; }

        public string Email { get; set; }


        public int? ParentCommentID { get; set; }
        public Comment ParentComment { get; set; }

        public List<CommentsDto> SubComments { get; set; }

        public int BlogID { get; set; }

        public Blog Blog { get; set; }

    }
}
