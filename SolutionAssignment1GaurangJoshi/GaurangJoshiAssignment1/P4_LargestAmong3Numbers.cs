﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P4_LargestAmong3Numbers
    {
        public void LargestAmong3Numbers()
        {
            Console.Write("Enter The Value for no1 : ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value for no2 : ");
            int no2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value for no3 : ");
            int no3 = Convert.ToInt32(Console.ReadLine());
            if (no1>no2 && no1>no2) {
                Console.WriteLine("The no1 is largest among three numbers");
            }
            else if(no2>no1 && no2 > no3)
            {
                Console.WriteLine("The no2 is largest among three number");
            }
            else {
                Console.WriteLine("The no3 is largest among three number");
                }
          
        }
    }
}
