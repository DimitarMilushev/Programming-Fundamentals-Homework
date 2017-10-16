using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Firstarr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] Secondarr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length1 = Firstarr.Length;
            int length2 = Secondarr.Length;
            if (length1 > length2)
            {
                var maxArr = length1;
                for (int i = 0; i < length1; i++)
                {
                    maxArr = (Firstarr[i % length1] + Secondarr[i % length2]);
                    if (i >= length1)
                    {
                        break;
                    }
                    Console.Write(maxArr + " ");
                }
            }
            else
            {
                var maxArr = length2;
                for (int i = 0; i < length2; i++)
                {
                    maxArr = (Firstarr[i % length1] + Secondarr[i % length2]);
                    if (i >= length2)
                    {
                        break;
                    }
                    Console.Write(maxArr + " ");
                }
            }
            Console.WriteLine();
        }
    }
}