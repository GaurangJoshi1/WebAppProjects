using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P14_FindTheDigitCountOfNum
    {
        public void FindTheDigitCountOfNum()
        {
            Console.Write("Enter the number to get digit count :");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (num != 0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine("The number of digits in an integer is :"+count);
        }
    }
}
