using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        private static List<int> PrimesInRange(int start, int end)
        {
            var result = new List<int>();
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i < 2)
                    isPrime = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string numbers = String.Join(", ", PrimesInRange(start, end).ToArray());
            Console.WriteLine(numbers);
        }
    }
}
