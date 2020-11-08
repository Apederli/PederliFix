﻿using Microsoft.AspNetCore.Http;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

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
