using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Bussiness.Abstract
{
   public interface ISeriesCategoryService
    {
        List<SeriesCategory> GetAll();
        SeriesCategory Add(SeriesCategory seriesCategory);
        void Delete(int id);
    }
}
