using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static double CalPower(double firstNumber, double secondNumber)
        {
            return Math.Pow(firstNumber, secondNumber);
        }
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double result = CalPower(firstNumber, secondNumber);
            Console.WriteLine(result);
        }
    }
}