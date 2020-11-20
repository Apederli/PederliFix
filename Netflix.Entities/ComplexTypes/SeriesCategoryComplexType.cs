using System.Collections.Generic;

namespace Netflix.Entities.ComplexTypes
{
    public class SeriesCategoryComplexType
    {
        public Series Series { get; set; }
        public IEnumerable<Series> Serieses { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
