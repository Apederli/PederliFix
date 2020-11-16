using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Bussiness.Abstract
{
    public interface ISeasonService
    {

        Season Add(Season season);
        void Delete(int id);

        List<Season> GetbySeriesId(int id);
    }
}
