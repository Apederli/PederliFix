using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netflix.WebAdmin.ViewModel
{
    public class DatailPageViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
