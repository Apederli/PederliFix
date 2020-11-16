using Netflix.Core.DataAccess;
using Netflix.Core.DataAccess.EntityFreamwork;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.DataAccess.Abstract
{
    public interface IChapterDal: IEntityRepository<Chapter>
    {
    }
}
