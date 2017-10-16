using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void PrintPyramid(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                PrintPyramid(1, i);
            }
            for (int i = number; i >= 1; i--)
            {
                PrintPyramid(1, i);
            }
        }
    }
}