using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] array = new long[n];
            array[0] = 1;
            for (int i = 1; i < array.Length; i++)
            {
                int start = Math.Max(0, i - k);
                int end = i - 1;
                long sum = 0;
                for (int j = start; j <= end; j++)
                {
                    sum += array[j];
                }
                array[i] = sum;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
