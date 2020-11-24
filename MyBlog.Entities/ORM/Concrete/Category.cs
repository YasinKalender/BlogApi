using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Entities.ORM.Concrete
{
    public class Category:BaseEntity
    {

        public string CategoryName { get; set; }

        public List<CategoryBlog> CategoryBlogs { get; set; }


    }
}
