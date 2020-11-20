using Netflix.Core.DataAccess;
using Netflix.Entities;
using Netflix.Entities.ComplexTypes;

namespace Netflix.DataAccess.Abstract
{
    public interface ISeriesDal : IEntityRepository<Series>
    {
        SeriesCategoryComplexType GetCategoriesBySeriesId(int Id);
    }
}
