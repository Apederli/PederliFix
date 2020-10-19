using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Bussiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        Category GetById(int id);
    }
}
