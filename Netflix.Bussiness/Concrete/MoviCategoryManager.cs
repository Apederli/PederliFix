using System;
using System.Collections.Generic;
using System.Text;
using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;

namespace Netflix.Bussiness.Concrete
{
    public class MoviCategoryManager : IMovieCategoryService
    {
        private IMoviesCategoryDal _moviesCategoryDal;

        public MoviCategoryManager(IMoviesCategoryDal moviesCategoryDal)
        {
            _moviesCategoryDal = moviesCategoryDal;
        }
        public void Add(MoviesCategory moviesCategory)
        {
           _moviesCategoryDal.Add(moviesCategory);
        }

        public List<MoviesCategory> GetByCategoryId(int category)
        {
            return null;
        }
    }
}
