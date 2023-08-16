using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager writerManager = new WriterManager(new EfWriterRepository());

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer w)
		{
			WriterValidate wv= new WriterValidate();
			ValidationResult results=wv.Validate(w);
			if (results.IsValid)
			{
                writerManager.AddWriter(w);
                return RedirectToAction("Index", "Blog");
            }
			else
			{
                foreach (var item in results.Errors)
                {
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
			return View();
		}
	}
}


