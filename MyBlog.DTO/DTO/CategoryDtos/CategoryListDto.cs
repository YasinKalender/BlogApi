using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.DTO.DTO.CategoryDtos
{
    public class CategoryListDto:BaseDto
    {
        public string CategoryName { get; set; }
        public int CategoryBlogCount { get; set; }

    }
}
