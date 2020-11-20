using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System.Collections.Generic;
using System.Linq;

namespace Netflix.Bussiness.Concrete
{
    public class ChapterManager : IChapterService
    {
        private IChapterDal _chapterDal;
        private ISeasonDal _seasonDal;

        public ChapterManager(IChapterDal chapterDal, ISeasonDal seasonDal)
        {
            _chapterDal = chapterDal;
            _seasonDal = seasonDal;
        }

        public Chapter AddToSeason(SeasonChapterComplexType seasonChapterComplexType)
        {
            var chapters = _chapterDal.GetList();
            Chapter chapter = _chapterDal.Get(x => x.Name == seasonChapterComplexType.ChapterName);
            if (!chapters.Contains(chapter))
            {
                return _chapterDal.Add(chapter);
            }

             throw new System.NotImplementedException(); 
        }

        public Chapter Add(Chapter chapter)
        {

            Chapter _chapter = _chapterDal.Add(chapter);

            return _chapter;
        }

        

        public void Delete(int id)
        {
            var chapter = _chapterDal.Get(x => x.Id == id);
            _chapterDal.Delete(chapter);
        }

        public List<Chapter> GetListBySeriesId(int seriesId)
        {
            return _chapterDal.GetList(x => x.SeriesId == seriesId);
        }
    }
}
