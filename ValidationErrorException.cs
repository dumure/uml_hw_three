using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_three
{
    internal class ValidationErrorException : Exception
    {
        public ValidationErrorException(string? message) : base(message)
        {
        }

        public ValidationErrorException() { }
    }
}
