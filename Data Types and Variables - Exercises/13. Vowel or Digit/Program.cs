using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = Console.ReadLine();
            try
            {
                int digit = int.Parse(symbol);
                Console.WriteLine("digit");
            }
           catch(Exception)
            {
                if (symbol == "a" || symbol == "e" || symbol == "i" || symbol == "o" || symbol == "u")
                    Console.WriteLine("vowel");
                else
                    Console.WriteLine("other");
            }
        } 
    }
}