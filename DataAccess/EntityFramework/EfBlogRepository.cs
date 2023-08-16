using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    //Site içerisinde bir entity kullanırken ilişkili olduğu Entity den de veri almak istediğimiz zaman include metodunu kullanırız. Bunu yapmak için de Include metodunu kullanırız. Örneğin Blog sayfamız içinde CategoryName propertysinden veri almak istiyoruz. Blog sayfasının Repository kısmına girip 
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using(var c=new Context())
            {
                return c.Blogs.Include(c => c.Category).ToList();
            }
          
        }
    }
}
