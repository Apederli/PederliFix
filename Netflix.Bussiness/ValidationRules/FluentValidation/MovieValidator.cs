﻿using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Netflix.Bussiness.ValidationRules.FluentValidation
{
    public class MovieValidator : AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Director).NotNull();
            RuleFor(x => x.Summary).NotNull();
            RuleFor(x => x.Banner).NotNull();

        }
    }
}
