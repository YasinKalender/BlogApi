using Microsoft.EntityFrameworkCore;
using MyBlog.DAL.Context;
using MyBlog.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repository.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class,new()
    {
        private readonly ProjectContext _projectContext;

        public BaseRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        
        public async Task Add(T entity)
        {
        
            _projectContext.Set<T>().Add(entity);
            await _projectContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            
            _projectContext.Set<T>().Remove(entity);
            await _projectContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll()
        {
           
            return await _projectContext.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> expression)
        {
            
            return await _projectContext.Set<T>().Where(expression).ToListAsync();
        }

        public async Task<List<T>> GetAll<Tkey>(Expression<Func<T, Tkey>> keyselector)
        {
            
            return await _projectContext.Set<T>().OrderByDescending(keyselector).ToListAsync();
        }

        public async Task<List<T>> GetAll<Tkey>(Expression<Func<T, bool>> expression, Expression<Func<T, Tkey>> keyselector)
        {
           
            return await _projectContext.Set<T>().OrderByDescending(keyselector).ToListAsync();
        }

        public async Task<T> Getbyid(int id)
        {
            
            return await _projectContext.Set<T>().FindAsync(id);
        }

        public async Task<T> Getone(Expression<Func<T, bool>> expression)
        {
         
            return await _projectContext.Set<T>().FirstOrDefaultAsync(expression);
        }

       

        public async Task Update(T entity)
        {
         
            _projectContext.Entry(entity).State = EntityState.Modified;
            await _projectContext.SaveChangesAsync();
        }

        
    }
}
