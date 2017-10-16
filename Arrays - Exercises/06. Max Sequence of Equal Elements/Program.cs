using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < Numbers.Length; i++)
            {
                
                if (Numbers[i] == Numbers[i -1])
                {
                    ++length;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        start = bestStart;
                    }
                }
                else
                {
                    length = 1;
                    start = i;
                }
            }
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(Numbers[i] + " ");
            }
        }
    }
}
