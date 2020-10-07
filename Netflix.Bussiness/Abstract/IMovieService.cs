﻿using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Bussiness.Abstract
{
    public interface IMovieService
    {
        List<Movie> GetAll();
        List<Movie> GetByCategoryId(int categoryId);
        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(int id);
        void GetById(int id);

    }
}
