using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.WebApi.Models
{
    public class BlogUpdateModel
    {

        public int ID { get; set; }

        public string Title { get; set; }

        public string ShortTitle { get; set; }

        public string ContentTitle { get; set; }

        public string Image { get; set; }

        public int AppUserID { get; set; }

        public IFormFile Images { get; set; }
    }
}
