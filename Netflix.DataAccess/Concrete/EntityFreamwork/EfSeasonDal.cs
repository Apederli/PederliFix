﻿using Netflix.Core.DataAccess.EntityFreamwork;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;

namespace Netflix.DataAccess.Concrete.EntityFreamwork
{
    public class EfSeasonDal : EfEntityRepositoryBase<Season, NetflixContext>, ISeasonDal
    {
    }
}
