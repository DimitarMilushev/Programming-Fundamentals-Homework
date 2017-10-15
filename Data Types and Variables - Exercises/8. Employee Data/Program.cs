using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string Firstname = Console.ReadLine();
            string Lastname = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = Convert.ToChar(Console.ReadLine());
            ulong ID = ulong.Parse(Console.ReadLine());
            long uniqueNum = long.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {Firstname}");
            Console.WriteLine($"Last name: {Lastname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {ID}");
            Console.WriteLine($"Unique Employee number: {uniqueNum}");
        }
    }
}