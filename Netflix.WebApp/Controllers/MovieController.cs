using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Netflix.Bussiness.Abstract;
using Netflix.Entities;
using Netflix.WebApp.ViewModel;

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
