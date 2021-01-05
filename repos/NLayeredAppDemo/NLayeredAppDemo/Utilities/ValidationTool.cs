using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredAppDemo.Utilities
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entities)
        {
            
            var result = validator.Validate(entities);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);

            }
        }
    }
}
