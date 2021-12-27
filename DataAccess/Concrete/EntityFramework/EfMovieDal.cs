using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMovieDal : EfEntityRepositoryBase<Movie, Context>, IMovieDal
    {
        public List<Movie> GetMovieIncludeCategory()
        {
            using (var context = new Context())
            {
                return context.Set<Movie>().Include(m => m.Category).ToList();
            }
        }
        public Movie GetById(int movieId)
        {
            using (var context = new Context())
            {
                return context.Set<Movie>().Include(m => m.Category).FirstOrDefault(x => x.MovieId == movieId);
            }
        }

    }
}
