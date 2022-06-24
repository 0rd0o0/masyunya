using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyunyaForms
{
    class calc2
    {
        public static double Plus(double a, double b)
        {
            return a + b;
        }
        public static double Minus(double a, double b)
        {
            return a - b;
        }
        public static double Arif(double a, double b)
        {
            return (a + b) / 2;
        }
        public static double Geom(double a, double b)
        {
            return Math.Sqrt(a * b);
        }
        public static double Devision(double a, double b)
        {
            return a / b;
        }
        public static double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public static double Multiplex(double a, double b)
        {
            return a * b;
        }
        public static double Ex(double a)
        {
            return Math.Pow(Math.E, a);
        }
    }
}