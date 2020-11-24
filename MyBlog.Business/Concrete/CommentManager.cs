using MyBlog.Business.Abstract;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Concrete
{
    public class CommentManager : BaseManager<Comment>, ICommentService
    {

        private IBaseRepository<Comment> _baseRepository;
        private ICommentRepository _commentRepository;

        public CommentManager(IBaseRepository<Comment> baseRepository, ICommentRepository commentRepository) : base(baseRepository)
        {
            _baseRepository = baseRepository;
            _commentRepository = commentRepository;
        }

        public async Task<List<Comment>> WithBlogComments(int blogid, int? parentid)
        {
           return await _commentRepository.WithBlogComments(blogid, parentid);

            
        }
    }
}
