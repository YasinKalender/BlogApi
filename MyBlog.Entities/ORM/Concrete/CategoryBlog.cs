using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Entities.ORM.Concrete
{
    public class CategoryBlog:BaseEntity
    {

        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int BlogID { get; set; }

        public Blog Blog { get; set; }
    }
}
