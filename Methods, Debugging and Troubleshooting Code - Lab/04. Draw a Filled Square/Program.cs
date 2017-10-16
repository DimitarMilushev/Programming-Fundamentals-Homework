using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void UpperRow(int number)
        {
            Console.WriteLine(new string('-', number * 2));
        }
        static void MiddleRow(int number)
        {
            for (int j = 0; j < number - 2; j++)
            {
                Console.Write('-');
                for (int i = 1; i < number; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
        static void LowerRow(int number)
        {
            Console.WriteLine(new string('-', number * 2));
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            UpperRow(number);
            MiddleRow(number);
            LowerRow(number);
        }
    }
}
