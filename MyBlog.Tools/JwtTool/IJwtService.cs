using MyBlog.Entities.ORM.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Tools.JwtTool
{
    public interface IJwtService
    {

        JwtToken Token(AppUser appUser);
    }
}
