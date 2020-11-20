using Netflix.Entities;
using System.Collections.Generic;

namespace Netflix.Bussiness.Abstract
{
    public interface IMovieCategoryService
    {
        List<MoviesCategory> GetAll();
        List<MoviesCategory> GetByCategoryId(int categoryId);
        MoviesCategory Add(MoviesCategory movieCategory);
        void Update(MoviesCategory movieCategory);
        void Delete(int id);
        MoviesCategory GetById(int id);
        List<MoviesCategory> GetByMovieId(int id);

    }
}
