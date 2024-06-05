using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_three
{
    internal class MiddleNameValidator : IValidator<string?>
    {
        public bool Validate(string? value)
        {
            if (value == null) throw new ArgumentNullException();
            else
            {
                if (value[0] >= 65 && value[0] <= 90) return true;
                else throw new ValidationErrorException();
            }
        }
    }
}
