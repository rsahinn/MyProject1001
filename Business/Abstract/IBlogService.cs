using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);
        void DeleteBlog(Blog blog);
        void UpdateBlog(Blog blog);
        List<Blog> GetAll();
        Blog GetById(int id);
        List<Blog> GetBloglistWithCategory();
        List<Blog> GetAll(int id);

        List<Blog> GetAllFromWriter(int id);
        
        

    }
}
