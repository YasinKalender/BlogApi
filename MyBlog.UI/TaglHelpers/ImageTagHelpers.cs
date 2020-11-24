using Microsoft.AspNetCore.Razor.TagHelpers;
using MyBlog.UI.ApiService.Abstract;
using MyBlog.UI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.TaglHelpers
{

    [HtmlTargetElement("GetBlogImage")]
    public class ImageTagHelpers:TagHelper
       
    {
        private readonly IImageApiSerive _ımageApiSerive;
        public ImageTagHelpers(IImageApiSerive ımageApiSerive)
        {
            _ımageApiSerive = ımageApiSerive;
        }
        public int ID { get; set; }

        public ImageEnum image { get; set; } = ImageEnum.Home;
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
          var blog =  await _ımageApiSerive.GetBlogImage(ID);

            string html;

            if (image==ImageEnum.Home)
            {
                html = $"<img src='{blog}'> class='card-image-top'";
            }

            else
            {
                html = $"<img src='{blog}'> class='img-fluid rounded'";
            }
            

            output.Content.SetHtmlContent(html);
        }
    }
}
