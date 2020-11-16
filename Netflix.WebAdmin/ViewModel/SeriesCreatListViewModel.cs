using Microsoft.AspNetCore.Http;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Netflix.WebAdmin.ViewModel
{
    public class SeriesCreatListViewModel
    {

        public Series Series { get; set; }
        public List<Category> Categories { get; set; }
    }
}
