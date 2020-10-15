﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Netflix.Bussiness.Abstract;
using Netflix.Entities;
using Netflix.WebAdmin.ViewModel;

namespace Netflix.WebAdmin.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public MovieController(IMovieService movieService, IWebHostEnvironment webHostEnvironment)
        {
            _movieService = movieService;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult List(int page = 1, int pageSize = 5)
        {
            List<Movie> movieList = _movieService.GetAll();
            MovieListViewModel movieListViewModel = new MovieListViewModel()
            {
                Movies = movieList
            };
            return View(movieListViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MovieCreateViewModel movieCreateViewModel)
        {
            if (ModelState.IsValid)
            {
                string fileName = UploadFile(movieCreateViewModel);
                Movie movie = new Movie()
                {
                    Name = movieCreateViewModel.Name,
                    Director = movieCreateViewModel.Director,
                    Summary = movieCreateViewModel.Summary,
                    Banner = fileName
                };
                _movieService.Add(movie);
                return RedirectToAction("List");
            }

            return View();
        }

        private string UploadFile(MovieCreateViewModel movieCreateViewModel)
        {
            string fileName = null;
            if (movieCreateViewModel != null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                fileName = DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss") + "-" + movieCreateViewModel.FormFile.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    movieCreateViewModel.FormFile.CopyTo(fileStream);
                }
            }
            return fileName;
        }

        public IActionResult Delete(int id)
        {
            _movieService.Delete(id);

            return RedirectToAction("List");
        }
    }
}
