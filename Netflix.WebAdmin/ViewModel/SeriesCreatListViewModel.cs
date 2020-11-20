using Microsoft.AspNetCore.Mvc.Rendering;
using Netflix.Entities;
using System.Collections.Generic;

namespace Netflix.WebAdmin.ViewModel
{
    public class SeriesCreatListViewModel
    {
        public Series Series { get; set; }
        public Chapter Chapter { get; set; }
        public Season Season { get; set; }
        public List<Category> Categories { get; set; }


        public List<SelectListItem> selectFirstSeason = new List<SelectListItem>()
        {
                new SelectListItem() {Text ="1.Sezon"}
        };

        public List<SelectListItem> selectFirstChapter = new List<SelectListItem>()
        {
                new SelectListItem() {Text="1.Bölüm"}
        };
    }
}
