using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System.Collections.Generic;

namespace Netflix.Bussiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category Add(Category movie);
        void Update(Category movie);
        void Delete(int id);
        Category GetById(int id);

        MovieCategoryComplexType GetListByCategoryId(int? id);

        SeriesCategoryComplexType GetListSeriesByCategoryId(int? id);
    }
}
