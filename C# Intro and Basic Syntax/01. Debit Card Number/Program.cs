using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());

            var number3 = int.Parse(Console.ReadLine());
            var number4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{number1:D4} {number2:D4} {number3:D4} {number4:D4}");
        }
    }
}
