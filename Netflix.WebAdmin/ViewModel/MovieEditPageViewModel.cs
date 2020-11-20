using Microsoft.AspNetCore.Http;
using Netflix.Entities;
using System.Collections.Generic;

namespace Netflix.WebAdmin.ViewModel
{
    public class MovieEditPageViewModel
    {
        public Movie Movie { get; set; }
        public CategoryCheched CategoryCheched { get; set; }
        public List<CategoryCheched> Categorylist { get; set; }
        public List<Category> Categories { get; set; }
        public IFormFile FormFile { get; set; }
    }
}
