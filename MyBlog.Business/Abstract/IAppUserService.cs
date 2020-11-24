using MyBlog.DTO.DTO.AppUserDtos;
using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Abstract
{
    public interface IAppUserService : IBaseService<AppUser>
    {

        Task<AppUser> Login(AppUserDto appUserDto);

        Task<AppUser> GetUser(string username);
    }
}
