using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using FluentValidation;
using Netflix.Core.CrossCuttingConcerns.Validation.FluentValidat;


namespace Netflix.Core.Aspects.PostSharp
{
    public class FluentValidationAspect// : OnMethodBoundaryAspect
    {
        //Type _validatorType;
        //public FluentValidationAspect(Type validatorType)
        //{
        //    _validatorType = validatorType;
        //}
        //public override void OnEntry(MethodExecutionArgs args)
        //{
        //    var validator = (IValidator)Activator.CreateInstance(_validatorType);
        //    var entityType = _validatorType.BaseType.GetGenericArguments()[0];
        //    var entities = args.Arguments.Where(x => x.GetType() == entityType);
        //    foreach (var entity in entities)
        //    {
        //        ValidatorTool.FluentValidate(validator, entity);
        //    }
        //}

     
    }
}
