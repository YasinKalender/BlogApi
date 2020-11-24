using MyBlog.WebApi.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.WebApi.Models
{
    public class UploadImageModel
    {
        public string Name { get; set; }

        public string ErrorMessage { get; set; }

        public UploadStatus UploadStatus { get; set; }

    }
}
