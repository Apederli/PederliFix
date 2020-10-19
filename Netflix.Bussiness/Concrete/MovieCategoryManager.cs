using System;
using System.Collections.Generic;
using System.Text;
using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;

namespace Netflix.Bussiness.Concrete
{
    public class MovieCategoryManager : IMovieCategoryService
    {
        private IMoviesCategoryDal _moviesCategoryDal;

        public MovieCategoryManager(IMoviesCategoryDal moviesCategory)
        {
            _moviesCategoryDal = moviesCategory;
        }
        public void Add(MoviesCategory movie)
        {
            _moviesCategoryDal.Add(movie);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<MoviesCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<MoviesCategory> GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(MoviesCategory movie)
        {
            throw new NotImplementedException();
        }
    }
}
