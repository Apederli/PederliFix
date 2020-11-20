using Microsoft.AspNetCore.Mvc.Rendering;
using Netflix.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Netflix.WebAdmin.ViewModel
{
    public class SeriesDetailViewModel
    {
        public Series Series { get; set; }

        public Season Season { get; set; }

        public List<Season> Seasons { get; set; }

        public List<Chapter> Chapters { get; set; }

        public IEnumerable<Category> CategoryList { get; set; }


        public List<SelectListItem> selectSeason = new List<SelectListItem>()
        {
            new SelectListItem{Text="1.Sezon"},
            new SelectListItem{Text="2.Sezon"},
            new SelectListItem{Text="3.Sezon"},
            new SelectListItem{Text="4.Sezon"},
            new SelectListItem{Text="5.Sezon"},
            new SelectListItem{Text="6.Sezon"},
            new SelectListItem{Text="7.Sezon"},
            new SelectListItem{Text="8.Sezon"},
            new SelectListItem{Text="9.Sezon"},
            new SelectListItem{Text="10.Sezon"}
        };

        
    }
}
