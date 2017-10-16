using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        static int SumofEvenDigits(int number)
        {
            int sumEvens = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                    sumEvens += lastDigit;
                number /= 10;
            }
            return sumEvens;
        }
        static int SumofOddDigits(int number)
        {
            int sumOdds = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                    sumOdds += lastDigit;
                number /= 10;
            }
            return sumOdds;
        }
        private static int SumOfEvensAndOdds(int number)
        {
            int sumEvens = SumofEvenDigits(number);
            int sumOdds = SumofOddDigits(number);
            return sumEvens * sumOdds;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int result = SumOfEvensAndOdds(number);
            Console.WriteLine(result);
        }
    }
}