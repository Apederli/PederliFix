using FluentValidation;
using Netflix.Entities;

namespace Netflix.Bussiness.ValidationRules.FluentValidation
{
    public class SeasonValidator : AbstractValidator<Season>
    {
        public SeasonValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Title).NotEmpty();
        }
    }
}
