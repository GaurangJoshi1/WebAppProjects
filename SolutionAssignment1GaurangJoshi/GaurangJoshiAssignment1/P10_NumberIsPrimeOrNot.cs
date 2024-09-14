using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P10_NumberIsPrimeOrNot
    {
        public void NumberIsPrimeOrNot()
        {
            Console.Write("Enter the number to check it is prime number or not:");
            int num = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            if (num <= 1)
            {
                flag = false;
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    // if num is perfectly divisible by i 
                    // flag is set to 0 i.e false 
                    if (num % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
            }

            if (flag == true)
            {
                Console.WriteLine("The number is a Prime Number");
            }
            else
            {
                Console.WriteLine("The number is not a Prime Number");
            }

        }
    }
}
