using FluentValidation;
using FluentValidation.Resources;
using FluentValidation.Results;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace Netflix.Core.CrossCuttingConcerns.Validation.FluentValidat
{
    public class ValidatorTool
    {
        public static void FluentValidate(IValidator validator,object entity)
        {

            ValidationResult result = validator.Validate((IValidationContext) entity);

            if (result.Errors.Count > 0)
            {
                throw new FluentValidation.ValidationException(result.Errors); 
            }

           
        }
    }
}
