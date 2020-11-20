using Netflix.Entities;
using System.Collections.Generic;

namespace Netflix.Bussiness.Abstract
{
    public interface ISeriesCategoryService
    {
        List<SeriesCategory> GetAll();
        SeriesCategory Add(SeriesCategory seriesCategory);
        void Delete(int id);
    }
}
