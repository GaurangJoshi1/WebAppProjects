using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P7_LeapYearOrNot
    {
        public void LeapYearOrNot()
        {
            Console.Write("Enter the year to check leap year or not:  ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 == 0) || (year % 400 == 0)){
                Console.WriteLine(year + " Is a Leap Year ");
            }
            else {
                Console.WriteLine(year + " Is NOT a Leap Year ");
            }
        }
    }
}
