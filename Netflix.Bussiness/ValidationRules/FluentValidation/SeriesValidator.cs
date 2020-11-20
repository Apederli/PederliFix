using FluentValidation;
using Netflix.Entities;

namespace Netflix.Bussiness.ValidationRules.FluentValidation
{
    public class SeriesValidator : AbstractValidator<Series>
    {
        public SeriesValidator()
        {
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Summary).NotNull();
            RuleFor(x => x.Director).NotNull();
            RuleFor(x => x.Banner).NotNull();
            RuleFor(x => x.FormFile).NotNull();
        }
    }
}
