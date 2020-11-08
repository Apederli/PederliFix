using Netflix.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Entities
{
    public class MoviesCategory : IEntity
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
   
   
    }
}
