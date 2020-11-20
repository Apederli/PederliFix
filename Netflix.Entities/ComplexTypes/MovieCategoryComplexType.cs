using System.Collections.Generic;

namespace Netflix.Entities.ComplexTypes
{
    public class MovieCategoryComplexType
    {
        public IEnumerable<Movie> Movies { get; set; }
        public Category Category { get; set; }
        public Movie Movie { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
