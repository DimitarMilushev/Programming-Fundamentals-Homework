using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static string ClosestToCenter(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt(x1 * x1 + y1 * y1) > Math.Sqrt(x2 * x2 + y2 * y2))
                return $"({x2}, {y2})";
            else
                return $"({x1}, {y1})";
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(ClosestToCenter(x1, y1, x2, y2));
        }
    }
}