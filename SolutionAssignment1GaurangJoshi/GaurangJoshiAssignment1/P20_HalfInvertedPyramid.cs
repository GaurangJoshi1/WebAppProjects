using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P20_HalfInvertedPyramid
    {
        public void HalfInvertedPyramid()
        {
            Console.Write("Enter the no of rows for half Inverted pyramid using * : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = rows; i >= 1; --i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
    }
}
