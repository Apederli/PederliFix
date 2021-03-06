﻿using Microsoft.EntityFrameworkCore;
using Netflix.Entities;

namespace Netflix.DataAccess.Concrete.EntityFreamwork
{
    public class NetflixContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=00P31839;Database=Netflix;Trusted_Connection=True;",
            options => options.EnableRetryOnFailure());
        }



        public DbSet<Series> Series { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MoviesCategory> MoviesCategory { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Season> Seasons { get; set; }


    }
}
