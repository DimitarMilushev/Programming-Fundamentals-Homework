using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();

            for (int i = 0; i < Array.Length; i++)
            {
                int[] LeftRow = Array.Take(i).ToArray();
                int[] RightRow = Array.Skip(i + 1).ToArray();

                if (LeftRow.Sum() == RightRow.Sum())
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}