using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Bussiness.Abstract
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        List<Movie> GetByCategoryId(int categoryId);
        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(int id);
        Movie GetById(int id);

        MovieCategoryComplexType DetalPage(int id);

    }
}
