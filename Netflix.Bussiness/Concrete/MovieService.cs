using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using System.Collections.Generic;
using System.IO;
using Netflix.Bussiness.ValidationRules.FluentValidation;
using Netflix.Entities.ComplexTypes;
using Netflix.Core.CrossCuttingConcerns.Validation.FluentValidat;
using FluentValidation.Results;

namespace Netflix.Bussiness.Concrete
{
    public class MovieService : IMovieService
    {
        private IMovieDal _movieDal;
        private ICategoryDal _categoryDal;
        private IMoviesCategoryDal _moviesCategoryDal;
        public MovieService(IMovieDal movieDal, IMoviesCategoryDal moviesCategoryDal, ICategoryDal categoryDal)
        {
            _movieDal = movieDal;
            _moviesCategoryDal = moviesCategoryDal;
            _categoryDal = categoryDal;
        }
        
        public Movie Add(Movie movie)
        {
            ValidatorTool.FluentValidate(new MovieValidator(), movie);
            
            return _movieDal.Add(movie);
        }

       

        public void Delete(int id)
        {
            var movie = _movieDal.Get(a => a.Id == id);
            var pahth = Path.Combine(Directory.GetCurrentDirectory(),
                "C:\\Users\\Aydog\\source\\repos\\PederliFix\\Netflix.WebAdmin\\wwwroot\\images\\" + movie.Banner);
            var movieCategory = _moviesCategoryDal.GetList(x => x.MovieId == id);
            if (movieCategory != null)
            {
                foreach (var VARIABLE in movieCategory)
                {
                    _moviesCategoryDal.Delete(VARIABLE);
                }
            }

            if (System.IO.File.Exists(pahth))
            {
                System.IO.File.Delete(pahth);
            }
            _movieDal.Delete(movie);
        }

        public MovieCategoryComplexType DetalPage(int id)
        {
            return _movieDal.DetalPage(id);
        }

        public List<Movie> GetAll()
        {
            return _movieDal.GetList();
        }

        public List<Movie> GetByCategoryId(int categoryId)
        {
            return _movieDal.GetList();
        }

        public Movie GetById(int id)
        {
         return _movieDal.Get(a => a.Id == id);
        }

        public void Update(Movie movie)
        {
            _movieDal.Update(movie);
        }

    }
}
