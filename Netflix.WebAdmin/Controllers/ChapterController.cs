using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Netflix.Bussiness.Abstract;
using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using Netflix.WebAdmin.ViewModel;
using System.Collections.Generic;

namespace Netflix.WebAdmin.Controllers
{
    public class ChapterController : Controller
    {
        private readonly ISeriesService _seriesService;

        private readonly ISeasonService _seasonService;

        private readonly IChapterService _chapterService;

        public ChapterController(ISeriesService seriesService, ISeasonService seasonService, IChapterService chapterService)
        {
            _seriesService = seriesService;

            _seasonService = seasonService;

            _chapterService = chapterService;
        }

        public IActionResult Create(int Id)
        {
            Series series = _seriesService.GetById(Id);

            List<Season> seasons = _seasonService.GetbySeriesId(Id);

            SelectList selectSeason = new SelectList(seasons, "Id", "Name");

            ChapterCreateViewModel chapterCreateViewModel = new ChapterCreateViewModel
            {
                Series = series,
                SeasonSelectList = selectSeason,
                ChapterId = Id,
            };

            return View(chapterCreateViewModel);
        }


        [HttpPost]
        public IActionResult Create(Chapter chap, int Id)
        {
            Series series = _seriesService.GetById(Id);

            Chapter chapter = new Chapter()
            {
                SeriesId = Id,

                Name = chap.Name,

                Topic = chap.Topic,

                SeasonId = chap.SeasonId
            };

            _chapterService.Add(chapter);

            return RedirectToAction("Detail", "Series", new { Id });
        }




    }
}
