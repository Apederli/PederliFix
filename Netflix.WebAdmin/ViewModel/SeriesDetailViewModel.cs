using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netflix.WebAdmin.ViewModel
{
    public class SeriesDetailViewModel
    {
        public Series Series  { get; set; }
        public List<Season> Seasons { get; set; }
        public List<Chapter> Chapters { get; set; }
    }
}
