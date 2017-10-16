using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
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
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Factiorial(number));
        }
    }
}