using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;

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
        public void Add(MoviesCategory movieCategory)
        {
            _moviesCategoryDal.Add(movieCategory);
        }

        public void Delete(int id)
        {
            var resul=_moviesCategoryDal.Get(x=>x.Id==id);
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

        public void GetById(int id)
        {
             _moviesCategoryDal.Get(x => x.CategoryId == id);
        }

      

        public void Update(MoviesCategory movie)
        {
            throw new NotImplementedException();
        }
    }
}
