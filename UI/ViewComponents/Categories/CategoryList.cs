using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Categories
{
    public class CategoryList : ViewComponent
    {
        CategoryManager manager = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            return View(manager.GetAllCategories());
        }
    }
}
