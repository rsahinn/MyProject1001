using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentdal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentdal = commentDal;
        }

        public void AddComment(Comment comment)
        {
            _commentdal.Add(comment);
        }

        public List<Comment> GetAllComment(int id)
        {
            return _commentdal.GetAll(x=>x.BlogId==id);
        }
    }
}
