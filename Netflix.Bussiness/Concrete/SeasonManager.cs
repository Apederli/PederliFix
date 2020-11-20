using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System.Collections.Generic;
using System.Linq;

namespace Netflix.Bussiness.Concrete
{
    public class SeasonManager : ISeasonService
    {
        private ISeasonDal _seasonDal;

        private IChapterDal _chapterDal;

        public SeasonManager(ISeasonDal seasonDal, IChapterDal chapterDal)
        {
            _seasonDal = seasonDal;
            _chapterDal = chapterDal;
        }

        public Season Add(Season season)
        {
           List<Season> seasons= _seasonDal.GetList(x => x.Name.Contains(season.Name) && x.SeriesId == season.SeriesId);

           if (seasons.Count==0)
            {
                Season newSeason = _seasonDal.Add(season);

                return newSeason;
            }

            return season;
        }

        public Season AddToCahpter(SeasonChapterComplexType seasonChapterComplexType)
        {
            List<Season> seasons = _seasonDal.GetList(x=>x.Name.Contains(seasonChapterComplexType.SeasonName) && x.SeriesId==seasonChapterComplexType.SeriesId).ToList();

            if (seasons.Count>0)
            {
                throw new System.ArgumentException("Kaydetmet istediğiniz Kayıtlı");
            }

            Season _season = new Season
            {
                SeriesId = seasonChapterComplexType.SeriesId,

                Name = seasonChapterComplexType.SeasonName,

                Title = seasonChapterComplexType.SeasonTitle
            };

            return _seasonDal.Add(_season);
        }

        public void Delete(int id)
        {
            Season season = _seasonDal.Get(x => x.Id == id);

            List<Chapter> chapters = _chapterDal.GetList(x => x.SeasonId == id);

            foreach (var chapter in chapters)
            {
                _chapterDal.Delete(chapter);
            }

            _seasonDal.Delete(season);
        }

        public int GetSeriesBySeasonId(int id)
        {
            int seriesId = _seasonDal.Get(x=>x.Id==id).SeriesId;
            return seriesId;
        }

        public List<Season> GetAllSeasonsForSeries(int seriesId)
        {
            var listSeason = _seasonDal.GetList(x => x.SeriesId == seriesId);
            return listSeason;

        }

        public Season GetById(int id)
        {
            return _seasonDal.Get(x => x.Id == id);
        }

        public List<Season> GetbySeriesId(int id)
        {
             List<Season> seasons = _seasonDal.GetList(x => x.SeriesId == id);
            return seasons;
        }
    }
}
