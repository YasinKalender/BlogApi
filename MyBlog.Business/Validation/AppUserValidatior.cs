using FluentValidation;
using MyBlog.DTO.DTO.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Business.Validation
{
    public class AppUserValidatior:AbstractValidator<AppUserDto>
    {

        public AppUserValidatior()
        {
            RuleFor(i => i.Username).NotNull();
            RuleFor(i => i.Password).NotNull();
        }
    }
}
