using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_three
{
    internal class AddressValidator : IValidator<string?>
    {
        public bool Validate(string? value)
        {
            if (value == null) throw new ArgumentNullException();
            return true;
        }
    }
}
