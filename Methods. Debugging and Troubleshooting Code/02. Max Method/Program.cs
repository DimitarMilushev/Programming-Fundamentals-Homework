using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void GetMax(int FirstNumber, int SecondNumber)
        {
            if (FirstNumber > SecondNumber)
                Console.WriteLine(FirstNumber);
            else
                Console.WriteLine(SecondNumber);
        }
        static void Main(string[] args)
        {
            int FirstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            int ThirdNumber = int.Parse(Console.ReadLine());
            if (ThirdNumber > FirstNumber && ThirdNumber > SecondNumber)
                Console.WriteLine(ThirdNumber);
            else
                GetMax(FirstNumber, SecondNumber);
        }
    }
}