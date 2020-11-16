using Netflix.Core.DataAccess;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.DataAccess.Abstract
{
    public interface ISeriesCategoryDal : IEntityRepository<SeriesCategory>
    {
    }
}
