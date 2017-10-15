using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            int slot = 0;
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {FirstNumber}");
            Console.WriteLine($"b = {SecondNumber}");
            slot = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = slot;
            Console.WriteLine("After:");
            Console.WriteLine($"a = {FirstNumber}");
            Console.WriteLine($"b = {SecondNumber}");
        }
    }
}