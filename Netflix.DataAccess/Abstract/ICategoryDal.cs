using Netflix.Core.DataAccess;
using Netflix.Entities;
using Netflix.Entities.ComplexTypes;

namespace Netflix.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        MovieCategoryComplexType GetListByCategoryId(int? id);

        SeriesCategoryComplexType GetListSeriesByCategoryId(int? id);
    }
}
