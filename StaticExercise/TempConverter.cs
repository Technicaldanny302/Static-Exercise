using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FarenheitToCelsius (double farenheit)
        {
            var result = (farenheit - 32) / 1.8;

            return result;
        }

        public static double CelsiusToFahrenheit (double celsisus)
        {
            return (celsisus * 9) / 5 + 32;
        }
    }
}
