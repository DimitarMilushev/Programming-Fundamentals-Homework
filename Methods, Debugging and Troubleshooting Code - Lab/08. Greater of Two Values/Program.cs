using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        static int GetMax(int firstSymbol, int secondSymbol)
        {
            if (firstSymbol > secondSymbol)
                return firstSymbol;
            else
                return secondSymbol;
        }
        static char GetMax(char firstSymbol, char secondSymbol)
        {
            if (firstSymbol > secondSymbol)
                return (char)(firstSymbol);
            else
                return (char)(secondSymbol);
        }
        static string GetMax(string firstSymbol,string secondSymbol)
        {
            if (firstSymbol.CompareTo(secondSymbol) >= 0)
                return firstSymbol;
            else
                return secondSymbol;
        }
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int firstSymbol = int.Parse(Console.ReadLine());
                int secondSymbol = int.Parse(Console.ReadLine());
                int Max = GetMax(firstSymbol, secondSymbol);
                Console.WriteLine(Max);
            }
            else if (type == "char")
            {
                char firstSymbol = char.Parse(Console.ReadLine());
                char secondSymbol = char.Parse(Console.ReadLine());
                char Max = GetMax(firstSymbol, secondSymbol);
                Console.WriteLine(Max);
            }
            else
            {
                string firstSymbol = Console.ReadLine();
                string secondSymbol = Console.ReadLine();
                string Max = GetMax(firstSymbol, secondSymbol);
                Console.WriteLine(Max);
            }
        }
    }
}