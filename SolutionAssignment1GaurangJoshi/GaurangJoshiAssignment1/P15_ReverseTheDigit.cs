using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P15_ReverseTheDigit
    {
        public void ReverseTheDigit()
        {
            Console.Write("Enter the number to Reverse : ");
            int num = Convert.ToInt32(Console.ReadLine());
            string str = Convert.ToString(num);
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            str = new string(arr);
            num = Convert.ToInt32(str);
            Console.WriteLine(num);
        }
    }
}
