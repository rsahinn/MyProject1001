using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogdal;

        public BlogManager(IBlogDal blogdal)
        {
            _blogdal = blogdal;
        }

        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }


        public void DeleteBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            return _blogdal.GetAll();
        }

        public List<Blog> GetAll(int id)
        {
            return _blogdal.GetAll(x => x.BlogId == id);
        }

		public List<Blog> GetAllFromWriter(int id)
		{
            return _blogdal.GetAll(x => x.WriterId == id);

		}

		public List<Blog> GetBloglistWithCategory()
        {
            return _blogdal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
