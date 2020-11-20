using Microsoft.AspNetCore.Mvc;
using Netflix.Bussiness.Abstract;
using Netflix.WebApp.Models;
using Netflix.WebApp.ViewModel;
using System.Diagnostics;

namespace Netflix.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISeriesService _seriesService;
        public HomeController(ISeriesService seriesService)
        {
            _seriesService = seriesService;
        }

        public IActionResult Index()
        {
            var seriesList = _seriesService.GetAll();
            SeriesMovieViewModel seriesMovieViewModel = new SeriesMovieViewModel()
            {
                Series = seriesList
            };
            return View(seriesMovieViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
