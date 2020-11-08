using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Netflix.Entities;
using System.ComponentModel.DataAnnotations;

namespace Netflix.WebAdmin.ViewModel
{
    public class MovieCreateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Director { get; set; }
        public string ImagePath { get; set; }
        [Required]
        public IFormFile FormFile { get; set; }
        public Movie Movie { get; set; }
        public Category Category { get; set; }
        public List<Category> Categories { get; set; }
        public MoviesCategory MoviesCategory { get; set; }

     
    }
}
