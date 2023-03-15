using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basiccoreprogram
{
    public class largestnumber
    {
        public static void Findlargest()
        {
            int num1, num2, num3;
            Console.WriteLine("FIND THE LARGEST NUMBER");
            Console.WriteLine("input the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the thrid number");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {

                if (num1 > num3)
                {
                    Console.WriteLine("The 1st number is the greatest among there");
                }
                else
                {

                    Console.WriteLine("The 3rd number is the greatest among there");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd number is the greatest among there");
            }
            else
            {
                Console.WriteLine("The 3rd number is the greatest among there");
            }

            }

        } 
}

