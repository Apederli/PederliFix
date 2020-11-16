using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
                //new SelectListItem() {Text ="2.Sezon"},
                //new SelectListItem() {Text ="3.Sezon"},
                //new SelectListItem() {Text ="4.Sezon"},
                //new SelectListItem() {Text ="5.Sezon"},
                //new SelectListItem() {Text ="6.Sezon"},
                //new SelectListItem() {Text ="7.Sezon"},
                //new SelectListItem() {Text ="8.Sezon"},
                //new SelectListItem() {Text ="9.Sezon"},
                //new SelectListItem() {Text ="10.Sezon"}
       };

        public List<SelectListItem> selectFirstChapter = new List<SelectListItem>()
        {
            new SelectListItem() {Text="1.Bölüm"}
        };
    }
}
