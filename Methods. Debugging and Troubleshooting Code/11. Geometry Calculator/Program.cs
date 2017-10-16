using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static double Calculator(string figure)
        {
            double result = 0;
           switch(figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double Theight = double.Parse(Console.ReadLine());
                    result = (side * Theight) / 2;
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    result = width * height;
                    break;
                case "square":
                    double Sside = double.Parse(Console.ReadLine());
                    result = Sside * Sside;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                     result = Math.Pow(radius, 2) * Math.PI;
                    break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            double result = Calculator(figure);
            Console.WriteLine($"{result:F2}");
        }
    }
}