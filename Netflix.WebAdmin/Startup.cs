using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Netflix.Bussiness.Abstract;
using Netflix.Bussiness.Concrete;
using Netflix.Bussiness.ValidationRules.FluentValidation;
using Netflix.DataAccess.Abstract;
using Netflix.DataAccess.Concrete.EntityFreamwork;
using Netflix.Entities;

namespace Netflix.WebAdmin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();

            services.AddScoped<IMovieDal, EfMovieDal>();

            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IMovieCategoryService, MovieCategoryManager>();

            services.AddScoped<IMoviesCategoryDal, EfMoviesCategoryDal>();

            services.AddScoped<ISeriesDal, EfSeriesDal>();

            services.AddScoped<ISeriesService, SeriesManager>();

            services.AddScoped<ISeasonDal, EfSeasonDal>();

            services.AddScoped<ISeasonService, SeasonManager>();

            services.AddScoped<IChapterService, ChapterManager>();

            services.AddScoped<IChapterDal, EfChapterDal>();

            services.AddScoped<ISeriesCategoryService, SeriesCategoryManager>();

            services.AddScoped<ISeriesCategoryDal, EfSeriesCategoryDal>();

            services.AddTransient<IValidator<Movie>, MovieValidator>();

            services.AddTransient<IValidator<Chapter>, ChapterValidator>();

            services.AddTransient<IValidator<Season>, SeasonValidator>();

            services.AddTransient<IValidator<Series>, SeriesValidator>();

            services.AddControllersWithViews().AddRazorRuntimeCompilation().AddFluentValidation();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Movie}/{action=List}/{id?}");
            });
        }
    }
}
