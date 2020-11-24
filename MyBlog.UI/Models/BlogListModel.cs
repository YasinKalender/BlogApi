using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.Models
{
    public class BlogListModel:BaseModel
    {

        public string Title { get; set; }

        public string ShortTitle { get; set; }

        public string ContentTitle { get; set; }

        public string Image { get; set; }
    }
}
