using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netflix.WebAdmin.ViewModel
{
    public class MovieCreateViewModel
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Director { get; set; }
        public IFormFile FormFile { get; set; }
    }
}
