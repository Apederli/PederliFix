using Netflix.Entities;
using System.Collections.Generic;

namespace Netflix.WebAdmin.ViewModel
{
    public class DatailPageViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
