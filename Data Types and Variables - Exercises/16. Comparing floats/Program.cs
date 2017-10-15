using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            bool equal = false;
            if ((decimal)firstNumber == (decimal)secondNumber)
                equal = true;
            Console.WriteLine(equal);
        }
    }
}