using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.Models
{
    public class CategoryModel
    {

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public bool Exist { get; set; }
    }
}
