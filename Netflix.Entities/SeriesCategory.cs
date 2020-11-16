using Netflix.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Entities
{
    public class SeriesCategory :IEntity
    {
        public int Id { get; set; }
        public int SeriesId { get; set; }
        public Series Series { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }

    }
}
