using Netflix.Entities;
using System.Collections.Generic;

namespace Netflix.WebApp.ViewModel
{
    public class SeriesMovieViewModel
    {
        public List<Series> Series { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
