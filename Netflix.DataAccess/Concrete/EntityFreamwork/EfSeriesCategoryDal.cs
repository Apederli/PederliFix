﻿using Netflix.Core.DataAccess.EntityFreamwork;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.DataAccess.Concrete.EntityFreamwork
{
    public class EfSeriesCategoryDal : EfEntityRepositoryBase<SeriesCategory,NetflixContext>,ISeriesCategoryDal
    {
    }
}
