using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();
            int result = 0;
            int firstLength = numbers.Length - 1;
            if (numbers.Length > 1)
            {
                for (int j = 0; j < firstLength ; j++)
                {
                    int[] condensed = new int[numbers.Length - 1];
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        condensed[i] = numbers[i] + numbers[i + 1];
                    }
                    numbers = condensed;
                    result = condensed[0];
                }
                Console.WriteLine(result);
            }
            else
            Console.WriteLine(numbers[0]);
        }
    }
}
