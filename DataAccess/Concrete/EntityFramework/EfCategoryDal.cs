using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, Context>, ICategoryDal
    {
        public Category GetById(int categoryId)
        {
            using (var context = new Context())
            {
                return context.Set<Category>().Include(c => c.Movies).FirstOrDefault(x => x.CategoryId == categoryId);
            }
        }

        public List<Category> GetListCategoryIncludeMovie()
        {
            using (var context = new Context())
            {
                return context.Set<Category>().Include(c => c.Movies).ToList();
            }
        }
          
    }
}
