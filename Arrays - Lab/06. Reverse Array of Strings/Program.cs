﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] +  " ");
            }
        }
    }
}
