using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExcercise
{
    public class TempConverter
    {
       public static double FahrenheitToCelsius(double fahrenheit)
        {
            
           var celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
            

        }
       public static double CelsiusToFahrenheit(double celsius)
        {
            var fahrenheit = (celsius * 9) / 5 + 32;
            return fahrenheit;
        }
    }
}
