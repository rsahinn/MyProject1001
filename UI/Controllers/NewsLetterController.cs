using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager manager = new NewsLetterManager(new EfNewsLetterRepository());
		
		[HttpGet]
		public IActionResult SubscribeMail()
		{
			return View();
		}
		[HttpPost]
		public IActionResult SubscribeMail(NewsLetter newsLetter)
		{
			newsLetter.MailStatus = true;
			manager.AddNewsLetter(newsLetter);
			return RedirectToAction("Index","Blog");
		}

	}
}
