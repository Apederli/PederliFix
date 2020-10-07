using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using System;
using System.Collections.Generic;

namespace Netflix.Bussiness.Concrete
{
    public class MovieService : IMovieService
    {
        private IMovieDal _movieDal;
        public MovieService(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public void Add(Movie movie)
        {
            _movieDal.Add(movie);
        }

        public void Delete(int id)
        {
            var movie = _movieDal.Get(a => a.Id == id);
            _movieDal.Delete(movie);
        }

        public List<Movie> GetAll()
        {
            return _movieDal.GetList();
        }

        public List<Movie> GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            _movieDal.Get(a => a.Id == id);
        }

        public void Update(Movie movie)
        {
            _movieDal.Update(movie);
        }

    }
}
