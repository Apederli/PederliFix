using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netflix.WebApp.ViewModel
{
    public class SeriesMovieViewModel
    {
        public List<Series> Series { get; set; }
        public Movie  Movie { get; set; }
    }
}
