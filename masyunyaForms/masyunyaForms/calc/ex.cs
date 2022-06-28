using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyunyaForms
{
    public class ex : IOneArgumentCalculator
    {
        public double Calculate(double a)
        {
            return Math.Pow(Math.E, a);
        }
    }
}
