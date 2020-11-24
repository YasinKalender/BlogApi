using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.DTO.DTO.CategoryBlogDtos
{
    public class CategoryBlogDto:BaseDto
    {

        public int CategoryID { get; set; }

        public int BlogID { get; set; }
    }
}
