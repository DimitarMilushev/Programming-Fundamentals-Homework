using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static int FiNumber(int number)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            for (int i = 0; i <= number; i++)
            {
                int slot = firstNumber;
                firstNumber = secondNumber;
                secondNumber = slot + secondNumber;
            }
            return firstNumber;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
                Console.WriteLine(FiNumber(number));
        }
    }
}