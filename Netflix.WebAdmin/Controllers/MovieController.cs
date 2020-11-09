using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Netflix.Bussiness.Abstract;
using Netflix.Entities;
using Netflix.WebAdmin.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

            MovieListViewModel getMovieListByCategoryId = new MovieListViewModel();

            if (Id != null)
            {
                var result = _categoryService.GetListByCategoryId(Id.Value);

                getMovieListByCategoryId.Movies = result.Movies;

                getMovieListByCategoryId.Category = result.Category;

                getMovieListByCategoryId.Categories = categoryList;

            }
            else
            {
                getMovieListByCategoryId.Movies = movieList;

                getMovieListByCategoryId.Categories = categoryList;
            }

            return View(getMovieListByCategoryId);
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

                Categories = result.Categories
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
        public IActionResult Edit(int[] categoryId, MovieEditPageViewModel movieView)
        {
            var editedMovie = _movieService.GetById(movieView.Movie.Id);

            var pahth = Path.Combine(Directory.GetCurrentDirectory(), "C:\\Users\\Aydog\\source\\repos\\PederliFix\\Netflix.WebAdmin\\wwwroot\\images\\" +
                editedMovie.Banner);

            string fileName = EditFile(movieView);


            editedMovie.Id = movieView.Movie.Id;

            editedMovie.Name = movieView.Movie.Name;

            editedMovie.Summary = movieView.Movie.Summary;

            editedMovie.Director = movieView.Movie.Director;


            if (movieView.FormFile != null)
            {
                System.IO.File.Delete(pahth);

                editedMovie.Banner = fileName;
            }


            var movieCategory = _movieCategoryService.GetAll().Where(x => x.MovieId == editedMovie.Id).ToList();

            _movieService.Update(editedMovie);

            // TODO: Update MovieCategory   => Gökhan Çınar => Önce MovieCategoydeki tüm verileri MovieId ye göre Sildim, sonra yeni gelen categoryleri movieCategory Tablosuna Tekrar Ekledim
            foreach (var item in movieCategory)
            {
                _movieCategoryService.Delete(item.Id);
            }

            foreach (var catId in categoryId)
            {
                var result = new MoviesCategory()
                {
                    CategoryId = catId,
                    MovieId = editedMovie.Id
                };
                _movieCategoryService.Add(result);

            }
            return RedirectToAction("List");
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

        private string EditFile(MovieEditPageViewModel movieEdit)
        {
            string fileName = null;
            if (movieEdit.FormFile != null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                fileName = DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss") + "-" + movieEdit.FormFile.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    movieEdit.FormFile.CopyTo(fileStream);
                }
            }

            return fileName;
        }
    }
}
