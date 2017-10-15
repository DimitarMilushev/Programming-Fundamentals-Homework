using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int count = 0;
            double sum = 0;
            bool specialnumber = false;
            while (count != range)
            {
                count++;
                int number = count;
                while (count > 0)
                {
                    sum += count % 10;
                    count = count / 10;
                }
                specialnumber = (sum == 5 || sum == 7 || sum == 11);
                Console.WriteLine($"{number} -> {specialnumber}");
                sum = 0;
                count = number;
            }
        }
    }
}
