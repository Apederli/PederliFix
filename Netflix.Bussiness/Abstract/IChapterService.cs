using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System.Collections.Generic;

namespace Netflix.Bussiness.Abstract
{
    public interface IChapterService
    {
        Chapter AddToSeason(SeasonChapterComplexType seasonChapterComplexType);

        Chapter Add(Chapter chapter);

        void Delete(int id);

        List<Chapter> GetListBySeriesId(int seriesId);
    }
}
