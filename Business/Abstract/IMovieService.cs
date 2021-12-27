using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{ 
    public interface IMovieService
    {
        IDataResult<Movie> GetById(int productId);
        IDataResult<List<Movie>> GetList();
        IDataResult<List<Movie>> GetListByCategory(int categoryId);
        IDataResult<List<Movie>> GetListMovieIncludeCategory();
        IResult Add(Movie movie);
        IResult Delete(Movie movie);
        IResult Update(Movie movie);

        IResult TransactionalOperation(Movie movie);

    }
}
