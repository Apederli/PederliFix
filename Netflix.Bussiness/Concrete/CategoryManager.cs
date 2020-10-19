using System;
using System.Collections.Generic;
using System.Text;
using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;

namespace Netflix.Bussiness.Concrete
{
   public class CategoryManager :ICategoryService
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

        public List<Category> GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Add(Category movie)
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

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
