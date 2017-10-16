using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens =
                Console.ReadLine()
                .Split('|');

            List<int> result = new List<int>();

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                int[] numbers = tokens[i]
                 .Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                result.AddRange(numbers);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}