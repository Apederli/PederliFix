using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Netflix.Entities;

namespace Netflix.WebAdmin.ViewModel
{
    public class MovieCreateViewModel
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Director { get; set; }
        public IFormFile FormFile { get; set; }

        public Category Category { get; set; }
        public List<Category> Categories { get; set; }
    }
}
