﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Netflix.Bussiness.Abstract;
using Netflix.Entities;
using Netflix.WebAdmin.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Http;
using Netflix.Entities.ComplexTypes;
using Netflix.Bussiness.ValidationRules.FluentValidation;
using Netflix.Core.CrossCuttingConcerns.Validation.FluentValidat;
using FluentValidation.Results;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Language;
using System.Reflection;

namespace Netflix.WebAdmin.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly ICategoryService _categoryService;
        private readonly IMovieCategoryService _movieCategoryService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MovieController(IMovieService movieService, IWebHostEnvironment webHostEnvironment,
            ICategoryService categoryService, IMovieCategoryService movieCategoryService)
        {
            _movieService = movieService;
            _categoryService = categoryService;
            _movieCategoryService = movieCategoryService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult List(int? Id)
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
                MovieListViewModel movieListViewModelWithCategory = new MovieListViewModel()
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
        public IActionResult Create(MovieCreateViewModel movieCreateViewModel, int[] Id)
        {
            if (ModelState.IsValid)
            {
                string fileName = UploadFile(movieCreateViewModel);
                Movie movie = new Movie()
                {
                    Name = movieCreateViewModel.Movie.Name,
                    Director = movieCreateViewModel.Movie.Director,
                    Summary = movieCreateViewModel.Movie.Summary,
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



        public IActionResult Delete(int id)
        {
            _movieService.Delete(id);

            return RedirectToAction("List");
        }


        public IActionResult Detail(int id)
        {
            var result = _movieService.DetalPage(id);
            DatailPageViewModel datailPage = new DatailPageViewModel()
            {
                Movie = result.Movie,
                Categories=result.Categories
            };
            return View(datailPage);
        }

        public IActionResult Edit(int id)        
        {
            var movie = _movieService.GetById(id);
            var categoryList = _categoryService.GetAll();
            var movieCategory = _movieCategoryService.GetAll().Where(x => x.MovieId == id).ToList();


            MovieEditPageViewModel movieEdit = new MovieEditPageViewModel();

            List<CategoryCheched> result = new List<CategoryCheched>();

            movieEdit.Movie = movie;

            foreach (var item in categoryList)
            {
                var categoryChecked = new CategoryCheched();

                categoryChecked.Id = item.Id;

                categoryChecked.CategoryName = item.CategoryName;


                foreach (var catId in movieCategory)
                {
                    if (item.Id == catId.CategoryId)
                    {
                        categoryChecked.IsCheked = true;
                        
                    }                    
                }

                result.Add(categoryChecked);
            }
            movieEdit.Categorylist = result;

            return View(movieEdit);

        }



        [HttpPost]
        public IActionResult Edit(int id, int[] categoryId, MovieCreateViewModel movieCreateViewModel)
        {
            //string pathConbine = Path.Combine(Directory.GetCurrentDirectory(),
            //    "C:\\Users\\Aydog\\source\\repos\\PederliFix\\Netflix.WebAdmin\\wwwroot\\images\\" + movieCreateViewModel.ImagePath);
            //if (movieCreateViewModel.FormFile != null)
            //{
            //    System.IO.File.Delete(pathConbine);
            //}

            //string fileName = UploadFile(movieCreateViewModel);
            //Movie movie = _movieService.GetById(id);
            //movie.Name = movieCreateViewModel.Name;
            //movie.Summary = movieCreateViewModel.Summary;
            //movie.Director = movieCreateViewModel.Director;
            //movie.Banner = fileName;
            //_movieService.Update(movie);

            //foreach (var IdCategory in categoryId)
            //{
            //    var categoryList = new MoviesCategory()
            //    {
            //        CategoryId = IdCategory,
            //        MovieId = movie.Id
            //    };
            //    _movieCategoryService.Update(categoryList);
            //}

            return View();
        }
        private string UploadFile(MovieCreateViewModel movieCreateViewModel)
        {
            string fileName = null;
            if (movieCreateViewModel.FormFile != null)
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
    }
}
