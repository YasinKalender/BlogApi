using MyBlog.Business.Abstract;
using MyBlog.DTO.DTO.AppUserDtos;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Concrete
{
    public class AppUserManager : BaseManager<AppUser>, IAppUserService
    {
        private readonly IBaseRepository<AppUser> _baseRepository;
       
        public AppUserManager(IBaseRepository<AppUser> baseRepository) : base(baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<AppUser> GetUser(string username)
        {
            return await _baseRepository.Getone(i => i.Username == username);
            
        }

        public async Task<AppUser> Login(AppUserDto appUserDto)
        {
           return await _baseRepository.Getone(i => i.Username == appUserDto.Username && i.Password == appUserDto.Password);
        }
    }
}
