using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Entities.ORM.Concrete
{
    public class AppUser:BaseEntity
    {

        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Lastname  { get; set; }

        public string Email { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
