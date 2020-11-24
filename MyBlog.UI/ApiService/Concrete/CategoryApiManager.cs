using MyBlog.DTO.DTO.CategoryDtos;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.UI.ApiService.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.UI.ApiService.Concrete
{
    public class CategoryApiManager : ICategoryApiService
    {

        private readonly HttpClient _httpClient;

        public CategoryApiManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:58353/api/category/");
        }

        public async Task<List<CategoryListDto>> CountBlog()
        {
            var response = await _httpClient.GetAsync("");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<CategoryListDto>>(await response.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task<List<CategoryListDto>> GetAll()
        {
            var reponse = await _httpClient.GetAsync("CategoryCount");

            if (reponse.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<CategoryListDto>>(await reponse.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task<CategoryListDto> GetByName(int id)
        {
            var response = await _httpClient.GetAsync($"{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<CategoryListDto>(await response.Content.ReadAsStringAsync());
            }

            return null;
        }

        public async Task CreateCategory(CategoryAddUpdateDto model)
        {
            var json = JsonConvert.SerializeObject(model);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            await _httpClient.PostAsync("", content);

           
        }

        public async Task UpdateCategory(CategoryAddUpdateDto model)
        {

            var jsondata = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsondata, Encoding.UTF8, "application/json");

           await _httpClient.PutAsync($"{model.ID}", content);


        }

        public async Task DeleteCategory(int id)
        {



            await _httpClient.DeleteAsync($"{id}");


        }
    }
}
