using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Exception;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.CrossCuttingConcerns.Validation;
using Core.Extensions;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class MovieManager : IMovieService
    {
        private IMovieDal _movieDal;
        private ICategoryService _categoryService;

        public MovieManager(IMovieDal movieDal, ICategoryService categoryService)
        {
            _movieDal = movieDal;
            _categoryService = categoryService;
        }

        [PerformanceAspect(1)]
        public IDataResult<Movie> GetById(int movieId)
        {
            return new SuccessDataResult<Movie>(_movieDal.GetById(movieId));
        }

        [PerformanceAspect(1)]
        public IDataResult<List<Movie>> GetList()
        {
            Thread.Sleep(5000);
            return new SuccessDataResult<List<Movie>>(_movieDal.GetList().ToList());
        }

        [LogAspect(typeof(FileLogger))]
        [CacheAspect(duration: 10)]
        public IDataResult<List<Movie>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Movie>>(_movieDal.GetList(p => p.CategoryId == categoryId).ToList());
        }


        [ValidationAspect(typeof(MovieValidator), Priority = 1)]
        [CacheRemoveAspect("IMovieService.Get")]
        public IResult Add(Movie movie)
        {
            IResult result = BusinessRules.Run(CheckIfMovieNameExists(movie.Name), CheckIfCategoryIsEnabled());

            if (result != null)
            {
                return result;
            }
            _movieDal.Add(movie);
            return new SuccessResult(Messages.Added);
        }

        [PerformanceAspect(1)]
        public IDataResult<List<Movie>> GetListMovieIncludeCategory()
        {
            return new SuccessDataResult<List<Movie>>(_movieDal.GetMovieIncludeCategory());
        }

        private IResult CheckIfMovieNameExists(string movieName)
        {

            var result = _movieDal.GetList(p => p.Name == movieName).Any();
            if (result)
            {
                return new ErrorResult(Messages.NameAlreadyExists);
            }

            return new SuccessResult();
        }

        private IResult CheckIfCategoryIsEnabled()
        {
            var result = _categoryService.GetList();
            if (result.Data.Count < 10)
            {
                return new ErrorResult(Messages.NameAlreadyExists);
            }

            return new SuccessResult();
        }

        public IResult Delete(Movie movie)
        {
            _movieDal.Delete(movie);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Update(Movie movie)
        {

            _movieDal.Update(movie);
            return new SuccessResult(Messages.Updated);
        }

        [TransactionScopeAspect]
        public IResult TransactionalOperation(Movie movie)
        {
            _movieDal.Update(movie);
            return new SuccessResult(Messages.Updated);
        }

    }
}
