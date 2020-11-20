using Netflix.Bussiness.Abstract;
using Netflix.Bussiness.ValidationRules.FluentValidation;
using Netflix.Core.CrossCuttingConcerns.Validation.FluentValidat;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Netflix.Bussiness.Concrete
{
    public class SeriesManager : ISeriesService
    {
        private ISeriesDal _seriesDal;

        private ISeriesCategoryDal _seriesCategoryDal;

        private ISeasonDal _seasonDal;

        private IChapterDal _chapterDal;

        public SeriesManager(ISeriesDal seriesDal, ISeriesCategoryDal seriesCategoryDal, ISeasonDal seasonDal, IChapterDal chapterDal)
        {
            _seriesDal = seriesDal;
            _seriesCategoryDal = seriesCategoryDal;
            _seasonDal = seasonDal;
            _chapterDal = chapterDal;
        }

        public Series Add(Series series)
        {
            ValidatorTool.FluentValidate(new SeriesValidator(), series);
            return _seriesDal.Add(series);
        }

        public void Delete(int id)
        {
            Series series = _seriesDal.Get(a => a.Id == id);

            List<Season> seasons = _seasonDal.GetList().Where(x => x.SeriesId == id).ToList();

            List<Chapter> chapters = _chapterDal.GetList().Where(x => x.SeriesId == id).ToList();

            if (series.Banner != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "C:\\Users\\aydogan.pederli\\source\\repos\\PederliFix\\Netflix.WebAdmin\\wwwroot\\images\\Series\\" + series.Banner);

                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }

            var seriesCategoryList = _seriesCategoryDal.GetList(x => x.SeriesId == id).ToList();

            foreach (var item in seriesCategoryList)
            {
                _seriesCategoryDal.Delete(item);
            }

            foreach (var chapter in chapters)
            {
                _chapterDal.Delete(chapter);
            }

            foreach (var season in seasons)
            {
                _seasonDal.Delete(season);
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
            return _seriesDal.Get(a => a.Id == id);
        }

        public SeriesCategoryComplexType GetCategoriesBySeriesId(int Id)
        {
            return _seriesDal.GetCategoriesBySeriesId(Id);
        }

        public void Update(Series series)
        {
            _seriesDal.Update(series);
        }
    }
}
