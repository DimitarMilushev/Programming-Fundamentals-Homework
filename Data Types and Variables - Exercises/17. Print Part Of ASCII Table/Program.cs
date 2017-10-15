using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            byte start = byte.Parse(Console.ReadLine());
            byte finish = byte.Parse(Console.ReadLine());
            for (int i = start; i <= finish; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}