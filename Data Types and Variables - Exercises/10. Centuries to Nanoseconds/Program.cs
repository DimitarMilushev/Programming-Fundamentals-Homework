using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            uint days = (uint)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            long second = minutes * 60;
            long milliseconds = second * 1000;
            long microseconds = milliseconds * 1000;
            ulong nanoseconds = (ulong)(milliseconds * 1000);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = " +
                $"{hours} hours = {minutes} minutes = {second} seconds = {milliseconds} milliseconds =" +
                $" {microseconds} microseconds = {nanoseconds}000 nanoseconds");
        }
    }
}