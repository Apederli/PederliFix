using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Entities.ComplexTypes
{
    public class MovieCategoryComplexType
    {
        public IEnumerable<Movie> Movies { get; set; }
        public Category Category { get; set; }

    }
}
