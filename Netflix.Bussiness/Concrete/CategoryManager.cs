using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }


        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.Id == id);
        }
    }
}
