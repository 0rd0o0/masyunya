﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyunyaForms
{
    class multiplex : ITwoArgumentsCalculator
    {
        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }
}