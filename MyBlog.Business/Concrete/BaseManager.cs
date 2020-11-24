using MyBlog.Business.Abstract;
using MyBlog.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Concrete
{
    public class BaseManager<T> : IBaseService<T> where T : class, new()
    {

        private  IBaseRepository<T> _baseRepository;

        public BaseManager(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public async Task Add(T entity)
        {
            await _baseRepository.Add(entity);
        }

        public async Task Delete(T entity)
        {
            await _baseRepository.Delete(entity);
        }

        public async Task<List<T>> GetAll()
        {
            return await _baseRepository.GetAll();
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> expression)
        {
            return await _baseRepository.GetAll(expression);
        }

        public async Task<List<T>> GetAll<Tkey>(Expression<Func<T, Tkey>> keyselector)
        {
            return await _baseRepository.GetAll(keyselector);
        }


        public async Task<List<T>> GetAll<Tkey>(Expression<Func<T, bool>> expression, Expression<Func<T, Tkey>> keyselector)
        {

            return await _baseRepository.GetAll(expression, keyselector);
        }

        public async Task<T> Getbyid(int id)
        {
            return await _baseRepository.Getbyid(id);
        }

        public async Task<T> Getone(Expression<Func<T, bool>> expression)
        {
            return await _baseRepository.Getone(expression);
        }


        public async Task Update(T entity)
        {
            await _baseRepository.Update(entity);
        }
    }
}
