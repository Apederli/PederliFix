using Netflix.Core.DataAccess;
using Netflix.Entities;
using Netflix.Entities.ComplexTypes;

namespace Netflix.DataAccess.Abstract
{
    public interface IMovieDal : IEntityRepository<Movie>
    {
        MovieCategoryComplexType DetalPage(int id);
    }
}
