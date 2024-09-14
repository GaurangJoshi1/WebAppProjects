using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P8_NumberIsPositiveOrNegative
    {
        public void NumberIsPositiveOrNegative()
        {
            Console.Write("Enter the number to check it is positive or negative :");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 0)
            {
                Console.WriteLine("number is positive");
            }
            else
            {
                Console.WriteLine("number is negative");
            }
        }
    }
}
