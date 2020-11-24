using Microsoft.AspNetCore.Http;
using MyBlog.DTO.DTO.AppUserDtos;
using MyBlog.Tools.JwtTool;
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
    public class AutApiManager : IAutApiService
    {

        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AutApiManager(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://localhost:58353/api/Auth/");
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<bool> Login(AppUserDto appUser)
        {
            var jsondata = JsonConvert.SerializeObject(appUser);

            var stringcontent = new StringContent(jsondata,Encoding.UTF8,"application/json");

           var response =await  _httpClient.PostAsync("Login",stringcontent);

            if (response.IsSuccessStatusCode)
            {
               var token =  JsonConvert.DeserializeObject<JwtToken>(await response.Content.ReadAsStringAsync());
                _httpContextAccessor.HttpContext.Session.SetString("token",token.Token);

                return true;
            }

            return false;
        }
    }
}
