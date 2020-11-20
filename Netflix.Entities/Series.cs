using Microsoft.AspNetCore.Http;
using Netflix.Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Netflix.Entities
{
    public class Series : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Director { get; set; }
        public string Banner { get; set; }
        public ICollection<SeriesCategory> SeriesCategory { get; set; }
        [NotMapped]
        public IFormFile FormFile { get; set; }
    }
}
