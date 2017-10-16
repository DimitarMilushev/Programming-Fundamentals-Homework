using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] FirstSentence = Console.ReadLine().Split(' ').ToArray();
            string[] SecondSentence = Console.ReadLine().Split(' ').ToArray();

            int rightCount = 0;
            int leftCount = 0;
            while (rightCount < FirstSentence.Length && rightCount < SecondSentence.Length)
            {
                if (FirstSentence[FirstSentence.Length - rightCount - 1] == SecondSentence[SecondSentence.Length - rightCount - 1])
                    ++rightCount;
                else
                    break;
            }
            while (leftCount < FirstSentence.Length && leftCount < SecondSentence.Length)
            {
                if (FirstSentence[leftCount] == SecondSentence[leftCount])
                    ++leftCount;
                else
                    break;
            }
            if (rightCount > leftCount)
                Console.WriteLine(rightCount);
            else
                Console.WriteLine(leftCount);
        }
    }
}
