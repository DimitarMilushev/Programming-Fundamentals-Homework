using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            byte people = byte.Parse(Console.ReadLine());
            byte capacity = byte.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)people / capacity);
            Console.WriteLine(courses);
        }
    }
}
