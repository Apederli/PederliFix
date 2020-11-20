using Microsoft.AspNetCore.Mvc.Rendering;
using Netflix.Entities;
using System.Collections.Generic;

namespace Netflix.WebAdmin.ViewModel
{
    public class ChapterCreateViewModel
    {
        public int ChapterId { get; set; }

        public Series Series { get; set; }

        public Chapter Chapter { get; set; }

        public Season Season { get; set; }

        public SelectList SeasonSelectList { get; set; }

        public List<SelectListItem> selectChapter = new List<SelectListItem>()
        {
            new SelectListItem {Text="1.Bölüm", Value="1.Bölüm"},
            new SelectListItem {Text="2.Bölüm", Value="2.Bölüm"},
            new SelectListItem {Text="3.Bölüm", Value="3.Bölüm"},
            new SelectListItem {Text="4.Bölüm", Value="4.Bölüm"},
            new SelectListItem {Text="5.Bölüm", Value="5.Bölüm"},
            new SelectListItem {Text="6.Bölüm", Value="6.Bölüm"},
            new SelectListItem {Text="7.Bölüm", Value="7.Bölüm"}
        };

      
    }
}
