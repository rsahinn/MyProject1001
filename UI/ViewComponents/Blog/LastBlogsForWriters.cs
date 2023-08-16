using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Blog
{
	public class LastBlogsForWriters:ViewComponent
	{
		BlogManager blogManager = new BlogManager(new EfBlogRepository());
		public IViewComponentResult Invoke()
		{
			return View(blogManager.GetAllFromWriter(1));
		}
	}
}
