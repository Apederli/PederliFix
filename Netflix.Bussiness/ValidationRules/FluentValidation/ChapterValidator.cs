using FluentValidation;
using Netflix.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Netflix.Bussiness.ValidationRules.FluentValidation
{
   public class ChapterValidator :AbstractValidator<Chapter>
    {
        public ChapterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boooooş yook");
            RuleFor(x => x.Topic).NotEmpty();
        }
    }
}
