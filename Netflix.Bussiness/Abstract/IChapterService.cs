using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Bussiness.Abstract
{
    public interface IChapterService
    {
        Chapter Add(Chapter season);
        void Delete(int id);

        List<Chapter> GetListBySeriesId(int seriesId);
    }
}
