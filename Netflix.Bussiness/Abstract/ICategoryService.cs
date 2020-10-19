using System;
using System.Collections.Generic;
using System.Text;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;

namespace Netflix.Bussiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetByCategoryId(int categoryId);
        void Add(Category movie);
        void Update(Category movie);
        void Delete(int id);
        void GetById(int id);
    }
}
