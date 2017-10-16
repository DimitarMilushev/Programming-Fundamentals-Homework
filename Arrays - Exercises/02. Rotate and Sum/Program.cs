using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int rotations = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Count];
            for (int i = 0; i < rotations; i++)
            { 
                    array.Insert(0, array[array.Count - 1]);
                    array.RemoveAt(array.Count - 1);
                for (int j = 0; j < array.Count; j++)
                {
                    sum[j] += array[j];
                }
            }
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}