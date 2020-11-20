using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using System;
using System.Collections.Generic;

namespace Netflix.Bussiness.Concrete
{
    public class MovieCategoryManager : IMovieCategoryService
    {
        private IMoviesCategoryDal _moviesCategoryDal;
        private IMovieDal _movieDal;

        public MovieCategoryManager(IMoviesCategoryDal moviesCategoryDal, IMovieDal movieDal)
        {
            _moviesCategoryDal = moviesCategoryDal;
            _movieDal = movieDal;
        }
        public MoviesCategory Add(MoviesCategory movieCategory)
        {
            return _moviesCategoryDal.Add(movieCategory);
        }

        public void Delete(int id)
        {
            var resul = _moviesCategoryDal.Get(x => x.Id == id);
            _moviesCategoryDal.Delete(resul);
        }

        public List<MoviesCategory> GetAll()
        {
            return _moviesCategoryDal.GetList();
        }

        public List<MoviesCategory> GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public MoviesCategory GetById(int id)
        {
            return _moviesCategoryDal.Get(x => x.CategoryId == id);
        }

        public List<MoviesCategory> GetByMovieId(int id)
        {
            return _moviesCategoryDal.GetList(x => x.Id == id);
        }

        public void Update(MoviesCategory movie)
        {
            _moviesCategoryDal.Update(movie);
        }
    }
}
