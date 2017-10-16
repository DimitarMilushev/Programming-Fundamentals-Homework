using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            bool[] primes = new bool[range + 1];

            for (int i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
                for (int j = 2; j <= Math.Sqrt(range); j++)
                {
                    if (primes[i] == true)
                    {
                        for (int h = j * j; h < primes.Length; h+= j)
                        {
                            primes[h] = false;
                        }
                    }
                }
            }
            List<int> result = new List<int>();
            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
