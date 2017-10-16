using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] FistWord = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] SecondWord = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] Letters1 = FistWord;
            char[] Letters2 = SecondWord;
            int index = 0;
            while (true)
            {
                if (FistWord[index] < SecondWord[index]) break;
                if (FistWord[index] > SecondWord[index])
                {
                    Letters1 = SecondWord;
                    Letters2 = FistWord;
                    break;
                }
                else
                {
                    index++;
                    if (FistWord.Length == index) break;
                    else if (SecondWord.Length == index)
                    {
                        Letters1 = SecondWord;
                        Letters2 = FistWord;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join("", Letters1));
            Console.WriteLine(string.Join("", Letters2));
        }
    }
}