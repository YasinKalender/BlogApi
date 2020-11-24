using MyBlog.DAL.Context;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Repository.Concrete
{
    public class AppUserRepository:BaseRepository<AppUser>,IAppUserRepository
    {
        public AppUserRepository(ProjectContext projectContext):base(projectContext)
        {

        }
        
    }
}
