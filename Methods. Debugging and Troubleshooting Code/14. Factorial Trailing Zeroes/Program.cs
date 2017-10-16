using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14. Factorial_Trailing_Zeroes
{
    class Program
    {
        static BigInteger Factiorial(BigInteger number)
        {

            for (BigInteger i = number - 1; i >= 1; i--)
            {
                number *= i;
            }
            return number;
        }
        static int TrailZeroes(BigInteger result)
        {
            int counter = 0;
            while (result % 10 == 0)
            {
                result /= 10;
                ++counter;
            }
            return counter;
        }
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger result = Factiorial(number);
            Console.WriteLine(TrailZeroes(result));
        }
    }
}