using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static double Properties(string parameter, double side)
        {
            double face = Math.Sqrt((side * side) + (side * side));
            double space = Math.Sqrt((side * side) + (side * side) + (side * side));
            double volume = side * side * side;
            double area = Math.Pow(side,2) * 6;
            if (parameter == "face")
            {
                return face;
            }
            else if (parameter == "space")
            {
                return space;
            }
            else if (parameter == "volume")
                return volume;
            else
                return area;
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = Properties(parameter, side);
            Console.WriteLine($"{result:F2}");
        }
    }
}
