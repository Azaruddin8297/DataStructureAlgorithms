﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutreAlgorithm
{
    internal class Prime_1_1000
    {
        public static void check()
        {
            int count = 0;
            Console.WriteLine("Prime numbers between 0 and 1001 are: ");
            for (int i = 1; i < 1001; i++)
            {
                count = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.Write(i + "  ");
                    }
                }
            }
        }
    }
}
