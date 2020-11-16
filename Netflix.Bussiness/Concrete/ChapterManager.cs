using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Netflix.Bussiness.Concrete
{
    public class ChapterManager : IChapterService
    {
        private IChapterDal _chapterDal;

        public ChapterManager(IChapterDal chapterDal)
        {
            _chapterDal = chapterDal;
        }

        public Chapter Add(Chapter season)
        {
           return _chapterDal.Add(season);
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
