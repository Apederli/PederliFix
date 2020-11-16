using Netflix.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Entities
{
    
    public class Season :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public int SeriesId { get; set; }
    }
}
