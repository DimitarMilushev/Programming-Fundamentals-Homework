﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Be_Positive
{
    class Program
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<int>();
                var data = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        data.Add(currentNum);
                    }
                    else
                    {
                        if (j + 1 < numbers.Count)
                        {
                            currentNum += numbers[j + 1];
                            j++;
                        }

                        if (currentNum >= 0)
                        {
                            data.Add(currentNum);
                        }
                    }
                    }
                    if (data.Count == 0)
                        Console.WriteLine("(empty)");
                    else
                        Console.WriteLine(String.Join(" ",data));
            }
        }
    }
}