using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Fonction_Procedure
{
    public struct Fahrenheit
    {
        public double Temperature;

        public Fahrenheit(double temperature)
        {
            Temperature = temperature;
        }

        public Celsius ToCelsius()
        {
            return new Celsius((Temperature-32)*5/9);
        }
    }
}
