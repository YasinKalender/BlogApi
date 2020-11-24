using MyBlog.UI.ApiService.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyBlog.UI.ApiService.Concrete
{
    public class ImageApiManager:IImageApiSerive
    {

        private readonly HttpClient _httpClient;


        public ImageApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:58353/api/images/");
        }

        public async Task<string> GetBlogImage(int id)
        {
          var response =   await _httpClient.GetAsync($"BlogImage/{id}");

            if (response.IsSuccessStatusCode)
            {
               var bytes =  await response.Content.ReadAsByteArrayAsync();

                return $"data:image/jpeg;base64,{Convert.ToBase64String(bytes)}";
            }

            return null;


        }

    }
}
