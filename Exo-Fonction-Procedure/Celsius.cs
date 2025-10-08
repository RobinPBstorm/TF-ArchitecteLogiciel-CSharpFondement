using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Fonction_Procedure
{
    public struct Celsius
    {
        public double Temperature;

        public Celsius(double temperature)
        {
            Temperature = temperature;
        }

        public Fahrenheit ToFahrenheit() 
        {
            return new Fahrenheit((Temperature* 9/5) + 32);
        }
    }
}
