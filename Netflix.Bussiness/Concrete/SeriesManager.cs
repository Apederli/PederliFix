using Netflix.Bussiness.Abstract;
using Netflix.Bussiness.ValidationRules.FluentValidation;
using Netflix.Core.CrossCuttingConcerns.Validation.FluentValidat;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Netflix.Bussiness.Concrete
{
    public class SeriesManager :ISeriesService
    {
        private ISeriesDal _seriesDal;
        private ISeriesCategoryDal _seriesCategoryDal;

        public SeriesManager(ISeriesDal seriesDal, ISeriesCategoryDal seriesCategoryDal)
        {
            _seriesDal = seriesDal;
            _seriesCategoryDal = seriesCategoryDal;
        }

        public Series Add(Series series)
        {
            ValidatorTool.FluentValidate(new SeriesValidator(), series);
            return _seriesDal.Add(series);
        }

        public void Delete(int id)
        {
            var series =_seriesDal.Get(a => a.Id == id);

            if(series.Banner != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(),
                "C:\\Users\\Aydog\\source\\repos\\PederliFix\\Netflix.WebAdmin\\wwwroot\\images\\Series" + series.Banner);
                if (System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.Delete(path);
                }

            }

            var seriesCategoryList=_seriesCategoryDal.GetList(x => x.SeriesId == id).ToList();

            foreach (var item in seriesCategoryList)
            {
                _seriesCategoryDal.Delete(item);
            }

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

        public Series GetById(int id)
        {
           return _seriesDal.Get(a=>a.Id==id);
        }

        public void Update(Series series)
        {
            _seriesDal.Update(series);
        }
    }
}
