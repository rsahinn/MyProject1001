using Business.Abstract;
using DataAccess.EntityFramework;
using DataAccess.Repository;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Concrete
{
    public class CategoryManager : ICategoryServices
    {
        EfCategoryRepository _efCategoryRepository;
        public CategoryManager()
        {
            _efCategoryRepository = new EfCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            _efCategoryRepository.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            _efCategoryRepository.Delete(category);
        }

        public List<Category> GetAllCategories()
        {
            return _efCategoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _efCategoryRepository.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
            _efCategoryRepository.Update(category);
        }
    }
}
