using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeofNumbers = int.Parse(Console.ReadLine());
            int sumofLastDigit = 0;
            int number = 0;
            bool specialNumber = false;
            for (int i = 1; i <= rangeofNumbers; i++)
            {
                number = i;
                while (i > 0)
                {
                    sumofLastDigit += i % 10;
                    i = i / 10;
                }
                specialNumber = (sumofLastDigit == 5) || (sumofLastDigit == 7) || (sumofLastDigit == 11);
                Console.WriteLine($"{number} -> {specialNumber}");
                sumofLastDigit = 0;
                i = number;
            }

        }
    }
}
