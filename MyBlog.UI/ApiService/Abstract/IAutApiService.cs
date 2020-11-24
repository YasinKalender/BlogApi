using MyBlog.DTO.DTO.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.UI.ApiService.Abstract
{
    public interface IAutApiService
    {

        Task<bool> Login(AppUserDto appUser);
    }
}
