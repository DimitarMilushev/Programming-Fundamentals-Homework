using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = decimal.Parse(Console.ReadLine());
            decimal kilometers = miles * 1.60934m;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
