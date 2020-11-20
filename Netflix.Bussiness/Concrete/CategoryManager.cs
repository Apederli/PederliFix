
using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System;
using System.Collections.Generic;

namespace Netflix.Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }


        public Category Add(Category movie)
        {
            throw new NotImplementedException();
        }

        public void Update(Category movie)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public MovieCategoryComplexType GetListByCategoryId(int? id)
        {
            return _categoryDal.GetListByCategoryId(id.Value);
        }

        public SeriesCategoryComplexType GetListSeriesByCategoryId(int? id)
        {
            return _categoryDal.GetListSeriesByCategoryId(id.Value);
        }
    }
}
