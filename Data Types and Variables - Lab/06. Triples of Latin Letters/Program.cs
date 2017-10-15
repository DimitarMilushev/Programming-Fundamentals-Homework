using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            byte triplets = byte.Parse(Console.ReadLine());
            for (int i  = 97; i  < 97+triplets; i ++)
            {
                for (int j = 97; j < 97 + triplets;j++)
                {
                    for (int h = 97; h < 97 + triplets; h++)
                        Console.WriteLine($"{(char)i}{(char)j}{(char)h}");
                }
            }
        }
    }
}