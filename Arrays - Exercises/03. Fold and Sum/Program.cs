using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{


    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = Numbers.Length / 4;

            int[] LeftRow = Numbers.Take(k).ToArray();
            int[] MidRow = Numbers.Skip(k).Take(k * 2).ToArray();
            int[] RightRow = Numbers.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(LeftRow);
            Array.Reverse(RightRow);

            int[] Sum = new int[k*2];
            for (int i = 0; i < k; i++)
            {
                Sum[i] = MidRow[i] + LeftRow[i];
                Sum[i + k] = MidRow[i + k] + RightRow[i];
            }
            Console.WriteLine(string.Join(" ", Sum));
        }
    }

}