using FluentValidation;
using FluentValidation.Results;

namespace Netflix.Core.CrossCuttingConcerns.Validation.FluentValidat
{
    public class ValidatorTool
    {
        public static void FluentValidate(IValidator validator, object entity)
        {

            ValidationResult result = validator.Validate(entity);

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }


        }
    }
}
