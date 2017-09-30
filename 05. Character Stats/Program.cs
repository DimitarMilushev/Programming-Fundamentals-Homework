using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var Name = Console.ReadLine();
            var hp = int.Parse(Console.ReadLine());
            var totalhp = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var totalenergy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', hp), new string('.', totalhp - hp));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', energy), new string('.', totalenergy - energy));
        }
    }
}
