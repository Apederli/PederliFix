using Netflix.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Entities
{
    public class SeriesCategory :IEntity
    {
        public int SeriesId { get; set; }
        public int CategoryId { get; set; }
    }
}
