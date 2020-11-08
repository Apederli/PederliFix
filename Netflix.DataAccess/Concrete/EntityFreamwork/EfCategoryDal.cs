﻿using Microsoft.EntityFrameworkCore;
using Netflix.Core.DataAccess.EntityFreamwork;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System.Linq;

namespace Netflix.DataAccess.Concrete.EntityFreamwork
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NetflixContext>, ICategoryDal
    {
        public MovieCategoryComplexType GetListByCategoryId(int ?id)
        {
            using (NetflixContext db = new NetflixContext())
            {
                var data = db
                    .Categories
                    .Where(c => c.Id == id.Value)
                    .Include(x => x.MoviesCategories)
                    .ThenInclude(m => m.Movie)
                    .Select(cat => new { Category = cat, Movie = cat.MoviesCategories.Select(x => x.Movie) }).FirstOrDefault();
                MovieCategoryComplexType movieCategoryComplexType = new MovieCategoryComplexType();
                if (data != null)
                {
                    movieCategoryComplexType.Movies = data.Movie;
                    movieCategoryComplexType.Category = data.Category;
                }

                return movieCategoryComplexType;
            }
          
        }



        public MovieCategoryComplexType forEdit(int id)
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
