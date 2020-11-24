using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.WebApi.Models;

namespace MyBlog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {

        public async Task<UploadImageModel> UploadImage(IFormFile file,string ContentType)
        {

            UploadImageModel model = new UploadImageModel();

            if (file != null)
            {
                if (file.ContentType!=ContentType)
                {
                    model.ErrorMessage = "Uygunsuz dosya türü";
                    model.UploadStatus = Models.Enum.UploadStatus.Error;
                    return model;
                }

                else
                {
                    var name = new Guid() + Path.GetExtension(file.FileName);
                    var image = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + name);

                    using var stream = new FileStream(image, FileMode.Create);
                    await file.CopyToAsync(stream);

                    model.Name = name;

                    model.UploadStatus = Models.Enum.UploadStatus.Success;

                    return model;
                }

            

            }

            model.ErrorMessage = "Dosya Yok";
            model.UploadStatus = Models.Enum.UploadStatus.NotExsit;
            return model;


        }
    }
}
