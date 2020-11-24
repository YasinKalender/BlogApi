using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.ApiService.Abstract
{
   public  interface IImageApiSerive
    {

        Task<string> GetBlogImage(int id);
    }
}
