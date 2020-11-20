using Netflix.Entities;
using System.Collections.Generic;

namespace Netflix.WebAdmin.ViewModel
{
    public class MovieListViewModel
    {
        public object jsonList { get; set; }
        public Movie Movie { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public List<Category> Categories { get; set; }
        public Category Category { get; set; }

    }
}
