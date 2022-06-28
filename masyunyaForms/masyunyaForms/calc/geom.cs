using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyunyaForms
{
    public class geom : ITwoArgumentsCalculator
    {
        public double Calculate(double a, double b)
        {
            return Math.Sqrt(a * b);
        }
    }
}
