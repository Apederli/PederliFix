using Netflix.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace Netflix.WebAdmin.ViewModel
{
    public class MovieListViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public List<Category> Categories { get; set; }
        public Category Category { get; set; }
    }
}
