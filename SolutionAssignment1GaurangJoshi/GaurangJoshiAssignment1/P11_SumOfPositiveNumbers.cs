using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P11_SumOfPositiveNumbers
    {
        public void SumOfPositiveNumbers()
        {
            Console.Write("Enter the number to make sum of positive numbers: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if(num > 0) {
                for(int i = 0; i <= num; ++i)
                {
                    sum = sum + i;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Enter Valid Positive number");
            }
        }
    }
}
