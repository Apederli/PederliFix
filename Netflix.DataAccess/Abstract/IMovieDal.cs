using Netflix.Core.DataAccess;
using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.DataAccess.Abstract
{
    public interface IMovieDal :IEntityRepository<Movie>
    {
        MovieCategoryComplexType DetalPage(int id);
    }
}
