using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyunyaForms
{
    class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case ("plus"):
                    {
                        return new plus();
                    }
                case ("minus"):
                    {
                        return new minus();
                    }
                case ("arif"):
                    {
                        return new arif();
                    }
                case ("geom"):
                    {
                        return new geom();
                    }
                case ("devision"):
                    {
                        return new devision();
                    }
                case ("multiplex"):
                    {
                        return new multiplex();
                    }
                case ("power"):
                    {
                        return new power();
                    }
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
