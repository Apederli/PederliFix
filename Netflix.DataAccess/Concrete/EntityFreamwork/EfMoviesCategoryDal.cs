using Netflix.Core.DataAccess.EntityFreamwork;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.DataAccess.Concrete.EntityFreamwork
{
    public class EfMoviesCategoryDal : EfEntityRepositoryBase<MoviesCategory,NetflixContext>,IMoviesCategoryDal
    {
    }
}
