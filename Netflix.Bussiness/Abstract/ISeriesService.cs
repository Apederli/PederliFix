﻿using Netflix.Entities;
using Netflix.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Bussiness.Abstract
{
    public interface ISeriesService
    {
        List<Series> GetAll();
        List<Series> GetByCategoryId(int categoryId);
        Series Add(Series series);
        void Update(Series series);
        void Delete(int id);
        Series GetById(int id);
    }
}
