﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basiccoreprogram
{
    public class harmonic
    {
        public static void harmonicnumber()
        {
            Console.WriteLine("Please enter the number for Harmonic Output : ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N == 0)
            {
                Console.WriteLine("The number entered should not be zero");
            }
            double sum = 0.0;

            for (int i = 1; i <= N; i++)
            {
                sum += 1.0 / i;


                Console.WriteLine("The " + i + "th Harmonic number is : ");
                Console.WriteLine("1.0 /" + i + " = " + sum);
            }

        }
    }
}
