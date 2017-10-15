using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            try
            {
                long validation = long.Parse(number);
                Console.WriteLine($"{validation} can fit in:");
                if (validation <= sbyte.MaxValue && sbyte.MinValue <= validation)
                    Console.WriteLine("* sbyte");
                if (validation <= byte.MaxValue && byte.MinValue <= validation)
                    Console.WriteLine("* byte");
                if (validation <= short.MaxValue && short.MinValue <= validation)
                    Console.WriteLine("* short");
                if (validation <= ushort.MaxValue && ushort.MinValue <= validation)
                    Console.WriteLine("* ushort");
                if (validation <= int.MaxValue && int.MinValue <= validation)
                    Console.WriteLine("* int");
                if (validation <= uint.MaxValue && uint.MinValue <= validation)
                    Console.WriteLine("* uint");
                if (validation <= long.MaxValue && long.MinValue <= validation)
                    Console.WriteLine("* long");
            }
            catch
            {
                    Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}