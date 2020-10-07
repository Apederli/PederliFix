using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Bussiness.Abstract
{
    public interface ISeriesService
    {
        List<Series> GetAll();
        List<Series> GetByCategoryId(int categoryId);
        void Add(Series series);
        void Update(Series series);
        void Delete(int id);
        void GetById(int id);
    }
}
