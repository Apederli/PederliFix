using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Bussiness.Concrete
{
    public class SeasonManager : ISeasonService
    {
        private ISeasonDal _seasonDal;

        public SeasonManager(ISeasonDal seasonDal)
        {
            _seasonDal = seasonDal;
        }

        public Season Add(Season season)
        {
            return _seasonDal.Add(season);
        }

        public void Delete(int id)
        {
            var season =_seasonDal.Get(x=>x.Id==id);
            _seasonDal.Delete(season);
        }


        public List<Season> GetbySeriesId(int id)
        {
            return _seasonDal.GetList(x=>x.SeriesId==id);
        }
    }
}
