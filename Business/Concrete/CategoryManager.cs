using Business.Abstract;
using DataAccess.Abstract;
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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void AddCategory(Category category)
        {
            _categoryDal.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryDal.GetAll();
        }

        public Category GetAllById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
