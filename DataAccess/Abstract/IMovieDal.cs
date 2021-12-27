using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMovieDal :IEntityRepository<Movie>
    {
        List<Movie> GetMovieIncludeCategory();
        Movie GetById(int movieId);
    }
}
