using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter= Convert.ToChar(Console.ReadLine());
            char secondLetter = Convert.ToChar(Console.ReadLine());
            char thirdLetter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"{thirdLetter}{secondLetter}{firstLetter}");
        }
    }
}