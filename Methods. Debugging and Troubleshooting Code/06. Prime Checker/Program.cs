using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    static void IsPrime(long number)
    {
        if (number < 2)
            return false;
        if (number < 4)
            return true;
        for (int i = 5; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());
        bool Prime = IsPrime(number);
        Console.WriteLine(Prime);
    }
}