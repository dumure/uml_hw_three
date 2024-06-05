using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_three
{
    internal class AgeValidator : IValidator<DateTime?>
    {
        public bool Validate(DateTime? value)
        {
            if (value == null) throw new ArgumentNullException();
            else
            {
                if ((DateTime.Now - value)?.Days / 365.0 >= 18) return true;
                else throw new ValidationErrorException();
            }
        }
    }
}
