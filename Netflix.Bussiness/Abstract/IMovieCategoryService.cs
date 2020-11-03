using System;
using System.Collections.Generic;
using System.Text;
using Netflix.Entities;

namespace Netflix.Bussiness.Abstract
{
    public interface IMovieCategoryService
    {
        List<MoviesCategory> GetAll();
        List<MoviesCategory> GetByCategoryId(int categoryId);
        void Add(MoviesCategory movieCategory);
        void Update(MoviesCategory movieCategory);
        void Delete(int id);
        MoviesCategory GetById(int id);
        List<MoviesCategory> GetByMovieId(int id);

    }
}
