using Microsoft.EntityFrameworkCore;
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

        public SeriesCategoryComplexType GetListSeriesByCategoryId(int? id)
        {
            using (NetflixContext db = new NetflixContext())
            {
                var data = db.Categories.Where(c => c.Id == id).Include(x => x.SeriesCategory).ThenInclude(s => s.Series)
                    .Select(cat => new { Category = cat, Series = cat.SeriesCategory.Select(x => x.Series) }).FirstOrDefault();
                SeriesCategoryComplexType seriesCategoryComplex = new SeriesCategoryComplexType();

                if(data != null)
                {
                    seriesCategoryComplex.Category = data.Category;
                    seriesCategoryComplex.Serieses = data.Series;
                }

                return seriesCategoryComplex;
                
            }
        }
    }
}
