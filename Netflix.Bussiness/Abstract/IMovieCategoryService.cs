using System;
using System.Collections.Generic;
using System.Text;
using Netflix.Entities;

namespace Netflix.Bussiness.Abstract
{
    public interface IMovieCategoryService
    {
        void Add(MoviesCategory moviesCategory);
        List<MoviesCategory> GetByCategoryId(int category);
    }
}
