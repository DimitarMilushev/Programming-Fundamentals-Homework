using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] days =
                {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
                int dayNum = int.Parse(Console.ReadLine());
                Console.WriteLine(days[dayNum - 1]);
            }
            catch
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}