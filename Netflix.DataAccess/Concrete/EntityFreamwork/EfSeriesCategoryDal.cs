using Netflix.Core.DataAccess.EntityFreamwork;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;

namespace Netflix.DataAccess.Concrete.EntityFreamwork
{
    public class EfSeriesCategoryDal : EfEntityRepositoryBase<SeriesCategory, NetflixContext>, ISeriesCategoryDal
    {
    }
}
