using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            var arr = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            } 
        }
    }
}