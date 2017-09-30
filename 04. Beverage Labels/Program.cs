using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var Name = Console.ReadLine();
            var Volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());
            energy = (Volume / 100) * energy;
            sugar = (Volume / 100) * sugar;

            Console.WriteLine($"{Volume}ml {Name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
