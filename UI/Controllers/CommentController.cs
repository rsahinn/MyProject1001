using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace UI.Controllers
{
	public class CommentController : Controller
	{
		CommentManager commentManager = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult PartialAddComment()
		{
			return View();
		}
		[HttpPost]
		public IActionResult PartialAddComment(Comment comment)
		{
			comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			comment.Status = true;
			comment.BlogId = 1;
			commentManager.AddComment(comment);
			return RedirectToAction("Index", "Blog");
		}
		public PartialViewResult CommentListFromBlog(int id)
		{
			var values = commentManager.GetAllComment(id);
			return PartialView(values);
		}
	}
}
