using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System.Collections.Generic;

namespace Netflix.Bussiness.Abstract
{
    public interface ISeasonService
    {
        Season Add(Season season);

        int GetSeriesBySeasonId(int id);

        Season AddToCahpter(SeasonChapterComplexType seasonChapterComplexType);
        
        void Delete(int id);
        
        Season GetById(int id);
        
        List<Season> GetbySeriesId(int id);

        List<Season> GetAllSeasonsForSeries(int seriesId);
    }
}