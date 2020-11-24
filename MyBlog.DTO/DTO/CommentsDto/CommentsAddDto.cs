using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.DTO.DTO.CommentsDto
{
    public class CommentsAddDto:BaseDto
    {

        public string Comments { get; set; }

        public string AuthorName { get; set; }

        public string Email { get; set; }


        public int? ParentCommentID { get; set; }

        public int BlogID { get; set; }


    }
}
