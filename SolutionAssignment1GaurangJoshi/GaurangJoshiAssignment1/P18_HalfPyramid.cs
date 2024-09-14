using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P18_HalfPyramid
    {
        public void HalfPyramid()
        {
            Console.Write("Enter the no of rows for half pyramid :");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
 }
