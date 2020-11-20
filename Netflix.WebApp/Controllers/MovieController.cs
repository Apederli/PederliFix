using Microsoft.AspNetCore.Mvc;
using Netflix.Bussiness.Abstract;
using Netflix.Entities;
using Netflix.WebApp.ViewModel;
using System.Collections.Generic;

namespace Netflix.WebApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public IActionResult MoviePageList()
        {
            List<Movie> getMovieList = _movieService.GetAll();
            SeriesMovieViewModel movielist = new SeriesMovieViewModel()
            {
                Movies = getMovieList
            };
            return View(movielist);
        }
    }
}
