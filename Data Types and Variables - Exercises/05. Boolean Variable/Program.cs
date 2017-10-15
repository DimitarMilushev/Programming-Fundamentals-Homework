using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool number = Convert.ToBoolean(Console.ReadLine());

            switch (number)
            {
                case true:
                    Console.WriteLine("Yes");
                    break;
                case false:
                    Console.WriteLine("No");
                    break;
            }
        }
    }
}
