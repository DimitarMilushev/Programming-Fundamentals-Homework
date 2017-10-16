using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Temperature_Conversion
{
    class Program
    {
        static double ConvertFromFahrenheit(double fahrenheit)
        {
            return ((fahrenheit - 32) * 5 / 9);
        }
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = ConvertFromFahrenheit(fahrenheit);
            Console.WriteLine($"{celsius:F2}");
        }
    }
}