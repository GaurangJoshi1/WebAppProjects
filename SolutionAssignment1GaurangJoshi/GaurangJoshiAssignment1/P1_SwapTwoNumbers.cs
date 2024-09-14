using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    public class P1_SwapTwoNumbers
    {
        public void SwapTwoNumbers()
        {
            Console.Write("Enter The Value for no1 : ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Value for no2 : ");
            int no2 = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = no1;
            no1 = no2;
            no2 = temp;
            Console.WriteLine("The no1 after swaping : " + no1);
            Console.WriteLine("The no2 after swaping : " + no2);
        }

    }
}
