using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Abstract
{
    public interface IBaseService<T> where T : class, new()
    {

        Task<List<T>> GetAll();

        Task<List<T>> GetAll(Expression<Func<T, bool>> expression);

        Task<List<T>> GetAll<Tkey>(Expression<Func<T, bool>> expression, Expression<Func<T, Tkey>> keyselector);

        Task<List<T>> GetAll<Tkey>(Expression<Func<T, Tkey>> keyselector);

        Task<T> Getone(Expression<Func<T, bool>> expression);

        Task<T> Getbyid(int id);

        Task Add(T entity);

        Task Update(T entity);

        Task Delete(T entity);
    }
}
