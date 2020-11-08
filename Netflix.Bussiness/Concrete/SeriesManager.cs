using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Bussiness.Concrete
{
    public class SeriesManager :ISeriesService
    {
        private ISeriesDal _seriesDal;

        public SeriesManager(ISeriesDal seriesDal)
        {
            _seriesDal = seriesDal;
        }

        public Series Add(Series series)
        {
           return _seriesDal.Add(series);
        }

        public void Delete(int id)
        {
            var series =_seriesDal.Get(a => a.Id == id);
            _seriesDal.Delete(series);
        }

        public List<Series> GetAll()
        {
            return _seriesDal.GetList();
        }

        public List<Series> GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            _seriesDal.Get(a=>a.Id==id);
        }

        public void Update(Series series)
        {
            _seriesDal.Update(series);
        }
    }
}
