using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyunyaForms
{
    public class arif : ITwoArgumentsCalculator
    {
        public double Calculate(double a, double b)
        {
            return (a + b) / 2;
        }
    }
}
