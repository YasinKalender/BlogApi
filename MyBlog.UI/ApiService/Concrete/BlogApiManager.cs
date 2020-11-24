using MyBlog.DTO.DTO.CategoryDtos;
using MyBlog.DTO.DTO.CommentsDto;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.UI.ApiService.Abstract;
using MyBlog.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.UI.ApiService.Concrete
{
    public class BlogApiManager : IBlogApiService
    {

        private readonly HttpClient _httpClient;


        public BlogApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:58353/api/blogs/");
        }
        public async Task<List<BlogListModel>> GetAll()
        {
            var response = await _httpClient.GetAsync("");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<BlogListModel>>(await response.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task<List<BlogListModel>> GetAllCategory(int? id)
        {
            var response = await _httpClient.GetAsync($"GetAllCategory/{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<BlogListModel>>(await response.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task<BlogListModel> GetOneBlog(int id)
        {
            var response = await _httpClient.GetAsync($"{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<BlogListModel>(await response.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task CreateBlog(BlogsAddModel model)
        {
            MultipartFormDataContent content = new MultipartFormDataContent();

            if (model.Images != null)
            {

                var bytes = await System.IO.File.ReadAllBytesAsync(model.Images.FileName);
                ByteArrayContent arraycontent = new ByteArrayContent(bytes);
                arraycontent.Headers.ContentType = new MediaTypeHeaderValue(model.Images.ContentType);

                content.Add(arraycontent, nameof(BlogsAddModel.Images), model.Images.FileName);



            }

            model.AppUserID = 1;
            content.Add(new StringContent(model.AppUserID.ToString()), nameof(BlogsAddModel.AppUserID));
            content.Add(new StringContent(model.ShortTitle), nameof(BlogsAddModel.ShortTitle));
            content.Add(new StringContent(model.Title), nameof(BlogsAddModel.Title));
            content.Add(new StringContent(model.ContentTitle), nameof(BlogsAddModel.ContentTitle));

            await _httpClient.PostAsync("", content);


        }

        public async Task UpdateBlog(BlogUpdate model)
        {
            MultipartFormDataContent content = new MultipartFormDataContent();

            if (model.Images != null)
            {

                var bytes = await System.IO.File.ReadAllBytesAsync(model.Images.FileName);
                ByteArrayContent arraycontent = new ByteArrayContent(bytes);
                arraycontent.Headers.ContentType = new MediaTypeHeaderValue(model.Images.ContentType);

                content.Add(arraycontent, nameof(BlogUpdate.Images), model.Images.FileName);



            }

            model.AppUserID = 1;
            content.Add(new StringContent(model.ID.ToString()), nameof(BlogUpdate.ID));
            content.Add(new StringContent(model.AppUserID.ToString()), nameof(BlogUpdate.AppUserID));
            content.Add(new StringContent(model.ShortTitle), nameof(BlogUpdate.ShortTitle));
            content.Add(new StringContent(model.Title), nameof(BlogUpdate.Title));
            content.Add(new StringContent(model.ContentTitle), nameof(BlogUpdate.ContentTitle));

            await _httpClient.PutAsync($"{model.ID}", content);


        }

        public async Task DeleteBlog(int id)
        {

            var response = await _httpClient.DeleteAsync($"{id}");


        }

        public async Task<List<CommentsDto>> GetComments(int id, int? parentid)
        {

            var response = await _httpClient.GetAsync($"{id}/GetComments?parentid={parentid}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<CommentsDto>>(await response.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task AddComment(CommentsAddDto comment)
        {

            var json = JsonConvert.SerializeObject(comment);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            await _httpClient.PostAsync("AddComment", data);

        }

        public async Task<List<CategoryListDto>> Category(int id)
        {

           var reponse =  await _httpClient.GetAsync($"{id}/category");

            if (reponse.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject <List<CategoryListDto>>(await reponse.Content.ReadAsStringAsync());
            }

            return null;

        }

        public async Task<List<Blog>> FiveBlog()
        {
            var reponse = await _httpClient.GetAsync("FiveBlog");

            if (reponse.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Blog>>(await reponse.Content.ReadAsStringAsync());
            }

            return null;


        }

        public async Task<List<BlogListModel>> BlogSearch(string s)
        {
            var reponse = await _httpClient.GetAsync($"BlogSearch?s{s}");

            if (reponse.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<BlogListModel>>(await reponse.Content.ReadAsStringAsync());
            }

            return null;


        }

        public async Task AddCategoryBlog(CategoryBlog categoryBlog)
        {
            var json = JsonConvert.SerializeObject(categoryBlog);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            await _httpClient.PostAsync("AddCategoryBlog", content);


        }

        public async Task RemoveCategoryBlogs(CategoryBlog categoryBlog)
        {
            await _httpClient.DeleteAsync($"RemoveCategoryBlogs?{nameof(CategoryBlog.CategoryID)}={categoryBlog.CategoryID}&{nameof(CategoryBlog.BlogID)}={categoryBlog.BlogID}");
        }
    }
}
