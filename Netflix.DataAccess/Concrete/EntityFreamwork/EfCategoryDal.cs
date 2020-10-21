using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Netflix.Core.DataAccess.EntityFreamwork;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Netflix.Entities.ComplexTypes;

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
                movieCategoryComplexType.Movies = data.Movie;
                movieCategoryComplexType.Category = data.Category;
                return movieCategoryComplexType;
            }
          
        }
    }
}
