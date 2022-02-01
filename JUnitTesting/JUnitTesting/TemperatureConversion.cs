using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitTesting
{
    public class TemperatureConversion
    {
        public void Conversion()
        {
            float fahrenheit, celsius;

            Console.WriteLine("Enter Temperature in celsius:");
            celsius = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Temperature in Fahrenheit : ");
            fahrenheit = float.Parse(Console.ReadLine());

            float sumCelsius = ((fahrenheit - 32) * 5 / 9);
            float sumfahrenheit = ((9 * celsius) / 5) + 32;


            Console.WriteLine("Temperature in Celsius : " + sumCelsius);
            Console.WriteLine("Temperature in fahrenheit : " + sumfahrenheit);

        }
    }
}
