using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using Netflix.Bussiness.ValidationRules.FluentValidation;
using Netflix.Core.Aspects.PostSharp;


namespace Netflix.Bussiness.Concrete
{
    public class MovieService : IMovieService
    {
        private IMovieDal _movieDal;
        public MovieService(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        [FluentValidationAspect(typeof(MovieValidator))]
        public void Add(Movie movie)
        {
            _movieDal.Add(movie);
        }


        public void Delete(int id)
        {
            var movie = _movieDal.Get(a => a.Id == id);
            var pahth = Path.Combine(Directory.GetCurrentDirectory(),
                "C:\\Users\\Aydog\\source\\repos\\PederliFix\\Netflix.Admin\\wwwroot\\"+movie.Banner);
            if (System.IO.File.Exists(pahth))
            {
                System.IO.File.Delete(pahth);

                _movieDal.Delete(movie);
            }
            
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
