using Microsoft.EntityFrameworkCore;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.DataAccess.Concrete.EntityFreamwork
{
    public class NetflixContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UKQTDKI\SQLEXPRESS;Database=Netflix;Trusted_Connection=True;",
            options => options.EnableRetryOnFailure());
        }
        public DbSet<Series> Series { get; set; }
        public DbSet<Movie> Movies { get; set; }
        //public DbSet<Admin> Admins { get; set; }
        //public DbSet<Season> Seasons { get; set; }
        //public DbSet<Chapter> Chapters { get; set; }
        //public DbSet<Category> Categories { get; set; }


    }
}
