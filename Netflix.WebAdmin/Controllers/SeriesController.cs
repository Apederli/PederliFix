using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Netflix.Bussiness.Abstract;
using Netflix.DataAccess.Abstract;
using Netflix.Entities;
using Netflix.WebAdmin.Utilities;
using Netflix.WebAdmin.ViewModel;

namespace Netflix.WebAdmin.Controllers
{
    public class SeriesController : Controller
    {
        private readonly ISeriesService _seriesService;
        private readonly ICategoryService _categoryService;
        private readonly ISeriesCategoryService _seriesCategoryService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        ImagesUpload images = new ImagesUpload();

        public SeriesController(ISeriesService seriesService, ICategoryService categoryService, ISeriesCategoryService seriesCategoryService, IWebHostEnvironment webHostEnvironment)
        {
            _seriesService = seriesService;
            _categoryService = categoryService;
            _seriesCategoryService = seriesCategoryService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult List(int? id)
        {
            var serieses = _seriesService.GetAll();

            var categories = _categoryService.GetAll();

            int seriesCategory;

            SeriesListViewModel seriesListViewModel = new SeriesListViewModel();

            if (id != null)
            {
                var result = _categoryService.GetListSeriesByCategoryId(id.Value);

                seriesListViewModel.Category = result.Category;

                seriesListViewModel.Serieses = result.Serieses;

                seriesListViewModel.Categories = categories;

                foreach (var series in serieses)
                {
                    seriesCategory = _seriesCategoryService.GetAll().Where(x => x.SeriesId == series.Id).Count();

                    seriesListViewModel.PiecesOfCategory = seriesCategory;
                }
            }
            else
            {
                seriesListViewModel.Serieses = serieses;

                seriesListViewModel.Categories = categories;

                foreach (var series in serieses)
                {
                    seriesCategory = _seriesCategoryService.GetAll().Where(x => x.SeriesId == series.Id).Count();

                    seriesListViewModel.PiecesOfCategory = seriesCategory;
                }
            }

            return View(seriesListViewModel);
        }



        public IActionResult Create()
        {
            SeriesCreatListViewModel seriesCreatListViewModel = new SeriesCreatListViewModel()
            {
                Categories = _categoryService.GetAll(),
            };

            return View(seriesCreatListViewModel);
        }

        [HttpPost]
        public IActionResult Create(SeriesCreatListViewModel seriesCreatListViewModel, int[] categoryId)
        {

            var banner = images.UploadImages(_webHostEnvironment.WebRootPath, "images\\Series", seriesCreatListViewModel.Series.FormFile);

            Series series = new Series()
            {
                Name = seriesCreatListViewModel.Series.Name,

                Summary = seriesCreatListViewModel.Series.Summary,

                Director = seriesCreatListViewModel.Series.Director,

                Banner = banner,

                FormFile = seriesCreatListViewModel.Series.FormFile
            };

            _seriesService.Add(series);


            foreach (var Id in categoryId)
            {
                SeriesCategory seriesCategory = new SeriesCategory()
                {
                    CategoryId = Id,

                    SeriesId = series.Id
                };
                _seriesCategoryService.Add(seriesCategory);
            }


            return RedirectToAction("List");
        }

        public IActionResult Edit(int Id)
        {
            var series = _seriesService.GetById(Id);

            var categories = _categoryService.GetAll();

            List<SeriesCategory> seriesCategory = _seriesCategoryService.GetAll().Where(x => x.SeriesId == Id).ToList();

            var checkedCategoryList = new List<CategoryCheched>();

            foreach (var category in categories)
            {
                CategoryCheched categoryChecked = new CategoryCheched();

                categoryChecked.Id = category.Id;

                categoryChecked.CategoryName = category.CategoryName;

                foreach (var catId in seriesCategory)
                {
                    if (category.Id == catId.CategoryId)
                    {
                        categoryChecked.IsCheked = true;
                    }
                }
                checkedCategoryList.Add(categoryChecked);
            }

            SeriesEditDetailViewModel seriesViewModel = new SeriesEditDetailViewModel()
            {
                Series = series,
                CategoryCheched = checkedCategoryList
            };

            return View(seriesViewModel);
        }

        [HttpPost]
        public IActionResult Edit(SeriesEditDetailViewModel seriesEditDetailViewModel,int[] seriesCategoryId)
        {

            Series series = _seriesService.GetById(seriesEditDetailViewModel.Series.Id);

            var path = Path.Combine(Directory.GetCurrentDirectory(), "C:\\Users\\Aydog\\source\\repos\\PederliFix\\Netflix.WebAdmin\\wwwroot\\images\\Series"+ seriesEditDetailViewModel.Series.Banner);

            series.Name = seriesEditDetailViewModel.Series.Name;

            series.Summary = seriesEditDetailViewModel.Series.Summary;

            series.Director = seriesEditDetailViewModel.Series.Director;

            if(seriesEditDetailViewModel.Series.FormFile != null)
            {
                if(seriesEditDetailViewModel.Series.Banner != null)
                {
                    System.IO.File.Delete(path);
                }
                string fileName = images.UploadImages(_webHostEnvironment.WebRootPath, "images\\Series", seriesEditDetailViewModel.Series.FormFile);

                series.Banner = fileName;
            }

            var seriesCategoryBySerisId = _seriesCategoryService.GetAll().Where(x => x.SeriesId == seriesEditDetailViewModel.Series.Id).ToList();

            _seriesService.Update(series);

            if(seriesCategoryId != null)
            {
                foreach (var item in seriesCategoryBySerisId)
                {
                    _seriesCategoryService.Delete(item.Id);
                }


                foreach (var item in seriesCategoryId)
                {
                    SeriesCategory seriesCategory = new SeriesCategory()
                    {
                        CategoryId = item,
                        SeriesId = series.Id
                    };
                    _seriesCategoryService.Add(seriesCategory);
                }

            }

            return RedirectToAction("List");
        }

        public IActionResult Delete (int Id)
        {
            _seriesService.Delete(Id);
            return RedirectToAction("List");
        }

        

    }
}
