using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Debugging_and_Troubleshooting_Code
{
    class Program
    {
        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            SayHello(name);
        }
    }
}