using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P2_NumberIsEvenOrOdd
    {
        public void NumberIsEvenOrOdd()
        {
            Console.Write("Enter The Number to Checking: ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            if(no1 == 0)
            {
                Console.WriteLine("Number ss neither ODD nor EVEN");
            }
            else if (no1 % 2 == 0)
            {
                Console.WriteLine("The Number Is EVEN");
            }
            else
            {
                Console.WriteLine("The Number Is ODD");
            }
        }
    }
}
