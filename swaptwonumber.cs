using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basiccoreprogram
{
    public class swaptwonumber
    {
        public static void Displayswapnumbers()
        {
            int a= 5 , b= 8;
            Console.WriteLine("Before swap a = " + a + "b =" + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swap a = " + a + "b =" + b);
        }

    }
}
