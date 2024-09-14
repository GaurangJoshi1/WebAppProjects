using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P12_FibonacciSeries
    {
        public void FibonacciSeries()
        {
            Console.Write("Enter the number to get fibonacci : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int firstTerm = 0, secondTerm = 1;
            Console.WriteLine("Fibonacci Series till " + num + " terms : ");

            for (int i = 1; i <= num; ++i)
            {
                Console.Write(firstTerm + ", ");

                // computing the next term
                int nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }
        }
    }
}
