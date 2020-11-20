using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System.Collections.Generic;

namespace Netflix.Bussiness.Abstract
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        List<Movie> GetByCategoryId(int categoryId);
        Movie Add(Movie movie);
        void Update(Movie movie);
        void Delete(int id);
        Movie GetById(int id);
        MovieCategoryComplexType DetalPage(int id);

    }
}
