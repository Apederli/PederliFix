
using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Netflix.Bussiness.Concrete
{
    public class SeriesCategoryManager : ISeriesCategoryService
    {
        private ISeriesCategoryDal _seriesCategoryDal;

        public SeriesCategoryManager(ISeriesCategoryDal seriesCategoryDal)
        {
            _seriesCategoryDal = seriesCategoryDal;
        }


        public SeriesCategory Add(SeriesCategory seriesCategory)
        {
            return _seriesCategoryDal.Add(seriesCategory);
        }

        public void Delete(int id)
        {
            var seriesCategory=_seriesCategoryDal.Get(x=>x.Id==id);
            _seriesCategoryDal.Delete(seriesCategory);
        }

        public List<SeriesCategory> GetAll()
        {
            return _seriesCategoryDal.GetList();
        }
    }
}

