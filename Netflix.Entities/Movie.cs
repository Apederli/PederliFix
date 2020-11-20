using Netflix.Core.Entities;
using System.Collections.Generic;

namespace Netflix.Entities
{
    public class Movie : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Director { get; set; }
        public string Banner { get; set; }
        public ICollection<MoviesCategory> MoviesCategories { get; set; }
    }
}
