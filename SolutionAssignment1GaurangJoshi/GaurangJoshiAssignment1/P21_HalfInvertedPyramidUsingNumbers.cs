using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P21_HalfInvertedPyramidUsingNumbers
    {
        public void HalfInvertedPyramidUsingNumbers()
        {
            Console.Write("Enter the no of rows for half Inverted pyramid using numbers : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = rows; i >= 1; --i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(" " +j);
                }
                Console.Write("\n");
            }
        }
    }
}
