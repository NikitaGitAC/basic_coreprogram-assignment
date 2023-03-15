using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basiccoreprogram
{
    public class quotientandreminder
    {
        public static void findquotientAndremainder()
        {


            int dividend = 35, divisor = 5;
            int remainder = dividend % divisor;
            int Quotient = dividend / divisor;
            Console.WriteLine("The dividend {0} and divisor {1}", dividend, divisor);
            Console.WriteLine("The quotient is" + Quotient++, "The remainder is" + remainder);
        }
   }
}
