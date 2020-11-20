using Microsoft.EntityFrameworkCore;
using Netflix.Core.DataAccess.EntityFreamwork;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System.Linq;

namespace Netflix.DataAccess.Concrete.EntityFreamwork
{
    public class EfSeriesDal : EfEntityRepositoryBase<Series, NetflixContext>, ISeriesDal
    {
        public SeriesCategoryComplexType GetCategoriesBySeriesId(int Id)
        {
            using (NetflixContext db = new NetflixContext())
            {
                var result = db.Series
                            .Where(s => s.Id == Id)
                            .Include(sc => sc.SeriesCategory)
                            .ThenInclude(c => c.Categories)
                            .Select(x => new { Series = x, Category = x.SeriesCategory.Select(c => c.Categories) }).FirstOrDefault();

                SeriesCategoryComplexType seriesCategoryComplexType = new SeriesCategoryComplexType()
                {
                    Series = result.Series,
                    Categories = result.Category
                };

                return seriesCategoryComplexType;
            };

        }
    }
}
