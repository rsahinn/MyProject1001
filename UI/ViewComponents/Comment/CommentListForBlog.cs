using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace UI.ViewComponents.Comment
{
    public class CommentListForBlog : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            return View(commentManager.GetAllComment(id));
        }
    }
}
