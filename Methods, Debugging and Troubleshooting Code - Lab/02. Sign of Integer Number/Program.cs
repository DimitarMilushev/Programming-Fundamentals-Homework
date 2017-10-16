using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void NumberType(int number)
        {
            if (number > 0)
                Console.WriteLine($"The number {number} is positive.");
            else if (number == 0)
                Console.WriteLine($"The number {number} is zero.");
            else
                Console.WriteLine($"The number {number} is negative.");

        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            NumberType(number);
        }
    }
}