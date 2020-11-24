using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Entities.ORM.Concrete
{
    public class Blog:BaseEntity
    {

        public string Title { get; set; }

        public string ShortTitle { get; set; }

        public string ContentTitle { get; set; }

        public string Image { get; set; }

        public int AppUserID { get; set; }

        public AppUser AppUser { get; set; }

        public List<Comment> Comments { get; set; }
        public List<CategoryBlog> CategoryBlogs { get; set; }
    }
}
