using Microsoft.AspNetCore.Http;
using Netflix.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml;

namespace Netflix.Entities
{
    public class Movie :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Director { get; set; }
        public string Banner { get; set; }

        [NotMapped]
        public IFormFile formFile { get; set; }

    }
}
