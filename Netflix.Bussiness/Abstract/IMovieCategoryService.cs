using System;
using System.Collections.Generic;
using System.Text;
using Netflix.Entities;

namespace Netflix.Bussiness.Abstract
{
    interface IMovieCategoryService
    {
        List<MoviesCategory> GetAll();
        List<MoviesCategory> GetByCategoryId(int categoryId);
        void Add(MoviesCategory movie);
        void Update(MoviesCategory movie);
        void Delete(int id);
        void GetById(int id);
    }
}
