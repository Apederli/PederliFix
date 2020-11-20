using Netflix.Core.DataAccess.EntityFreamwork;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;

namespace Netflix.DataAccess.Concrete.EntityFreamwork
{
    public class EfMoviesCategoryDal : EfEntityRepositoryBase<MoviesCategory, NetflixContext>, IMoviesCategoryDal
    {

    }
}
