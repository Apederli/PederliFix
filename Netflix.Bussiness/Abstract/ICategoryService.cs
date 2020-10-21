using System;
using System.Collections.Generic;
using System.Text;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using Netflix.Entities.ComplexTypes;

namespace Netflix.Bussiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category movie);
        void Update(Category movie);
        void Delete(int id);
        Category GetById(int id);

        MovieCategoryComplexType GetListByCategoryId(int ?id);
    }
}
