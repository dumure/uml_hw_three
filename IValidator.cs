﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_three
{
    internal interface IValidator<T>
    {
        bool Validate(T value);
    }
}
