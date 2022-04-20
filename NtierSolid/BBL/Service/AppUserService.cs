using BBL.Repository;
using DataAcces.Context;
using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL.Service
{
    public class AppUserService : ICategoryList,IProductList
    {
        ProjectContext db = new ProjectContext();
        public List<Category> GetListCategory()
        {
            return db.Categories.ToList();
        }

        public List<Product> GetListProduct()
        {
            return db.Products.ToList();
        }
    }
}
