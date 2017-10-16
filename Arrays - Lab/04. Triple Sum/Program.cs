using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool anydigits = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    
                    int sum = array[i] + array[j];
                    if (array.Contains(sum)) 
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} == {sum}");
                        anydigits = true;
                    }
                }
            }
            if (anydigits == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}