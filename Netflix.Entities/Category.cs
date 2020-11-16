using Netflix.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Entities
{
    public class Category :IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public ICollection<MoviesCategory> MoviesCategories { get; set; }

        public ICollection<SeriesCategory> SeriesCategory { get; set; }

    }
}
