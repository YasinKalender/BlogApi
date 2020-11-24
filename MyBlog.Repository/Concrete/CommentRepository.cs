using Microsoft.EntityFrameworkCore;
using MyBlog.DAL.Context;
using MyBlog.Entities.ORM.Concrete;
using MyBlog.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repository.Concrete
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {

        private readonly ProjectContext _projectContext;
        public CommentRepository(ProjectContext projectContext) : base(projectContext)
        {
            _projectContext = projectContext;
        }

        public async Task<List<Comment>> WithBlogComments(int blogid, int? parentid)
        {
            List<Comment> result = new List<Comment>();
            await GetComments(blogid, parentid, result);
            return result;
        }

        private async Task GetComments(int blogid, int? parentid, List<Comment> result)
        {
            var commnets = await _projectContext.Comments.Where(i => i.BlogID == blogid && i.ParentCommentID == parentid).OrderByDescending(i => i.AddDate).ToListAsync();

            if (commnets.Count > 0)
            {
                foreach (var item in commnets)
                {
                    if (item.SubComments == null)

                        item.SubComments = new List<Comment>();


                    await GetComments(item.BlogID, item.ID, item.SubComments);
                    if (!result.Contains(item))
                    {
                        result.Add(item);
                    }
                }
            }
        }
    }
}
