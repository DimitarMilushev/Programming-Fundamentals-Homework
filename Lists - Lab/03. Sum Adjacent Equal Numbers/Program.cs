﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();
            bool allSummed = true;
            while (allSummed)
            {
                allSummed = false;
                int index = 0;
                decimal sum = 0m;
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        index = i - 1;
                        sum = numbers[i] + numbers[i - 1];
                        allSummed = true;
                        break;
                    }
                   
                }
                if (allSummed)
                {
                    numbers.RemoveRange(index, 2);
                    numbers.Insert(index, sum);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}