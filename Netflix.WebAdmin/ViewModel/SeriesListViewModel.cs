using Netflix.Entities;
using System.Collections.Generic;

namespace Netflix.WebAdmin.ViewModel
{
    public class SeriesListViewModel
    {
        public Series Series { get; set; }
        public IEnumerable<Series> Serieses { get; set; }
        public List<Category> Categories { get; set; }
        public Category Category { get; set; }

        public int PiecesOfCategory { get; set; }

    }
}
