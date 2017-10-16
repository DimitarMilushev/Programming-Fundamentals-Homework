using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numarray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < numarray.Length ; i++)
            {
                double roundedNum = Math.Round(numarray[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numarray[i]} => {roundedNum}");
            }
        }
    }
}
