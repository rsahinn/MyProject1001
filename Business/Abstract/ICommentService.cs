using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        //void DeleteCategory(Comment category);
        //void UpdateCategory(Comment category);
        List<Comment> GetAllComment(int id);
        //Comment GetById(int id);
    }
}
