﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Netflix.Bussiness.Abstract;
using Netflix.Entities;
using Netflix.WebAdmin.ViewModel;
using System;
using System.IO;

namespace Netflix.WebAdmin.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly ICategoryService _categoryService;
        private readonly IMovieCategoryService _movieCategoryService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public MovieController(IMovieService movieService, IWebHostEnvironment webHostEnvironment, ICategoryService categoryService, IMovieCategoryService movieCategoryService)
        {
            _movieService = movieService;
            _categoryService = categoryService;
            _movieCategoryService = movieCategoryService;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult List(int ? Id)
        {
            var movieList = _movieService.GetAll();
            var categoryList = _categoryService.GetAll();
            MovieListViewModel movieListViewModel = new MovieListViewModel()
            {
                Movies = movieList,
                Categories = categoryList
            };

            if (Id != null)
            {
                var result = _categoryService.GetListByCategoryId(Id.Value);
                var movieListViewModelWithCategory = new MovieListViewModel()
                {
                    Movies = result.Movies,
                    Category = result.Category,
                    Categories = categoryList
                };
                return View(movieListViewModelWithCategory);
            }
           

            return View(movieListViewModel);
        }

        public IActionResult Create()
        {
            var categories = _categoryService.GetAll();
            MovieCreateViewModel movieCreate = new MovieCreateViewModel()
            {
                Categories = categories
            };

            return View(movieCreate);
        }

        [HttpPost]
        public IActionResult Create(MovieCreateViewModel movieCreateViewModel,int[] Id)
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

                foreach (var id in Id)
                {
                    var moviesCategory = new MoviesCategory
                    {
                        CategoryId = id,
                        MovieId = movie.Id
                    };
                    _movieCategoryService.Add(moviesCategory);
                }

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

        //github için
    }
}
