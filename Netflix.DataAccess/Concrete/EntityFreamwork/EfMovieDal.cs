using Microsoft.EntityFrameworkCore;
using Netflix.Core.DataAccess.EntityFreamwork;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Netflix.DataAccess.Concrete.EntityFreamwork
{
    public class EfMovieDal :EfEntityRepositoryBase<Movie,NetflixContext>,IMovieDal
    {

        public MovieCategoryComplexType DetalPage(int id)
        {
            using (NetflixContext db = new NetflixContext())
            {
                var data = db
                    .Movies
                    .Where(x => x.Id == id)
                    .Include(mc => mc.MoviesCategories)
                    .ThenInclude(c => c.Category)
                    .Select(x => new { Movie = x, Category = x.MoviesCategories.Select(c => c.Category) }).FirstOrDefault();

                MovieCategoryComplexType movieCategoryComplexType = new MovieCategoryComplexType();
                movieCategoryComplexType.Movie = data.Movie;
                movieCategoryComplexType.Categories = data.Category;
                return movieCategoryComplexType;
            };

        }
    }
}
