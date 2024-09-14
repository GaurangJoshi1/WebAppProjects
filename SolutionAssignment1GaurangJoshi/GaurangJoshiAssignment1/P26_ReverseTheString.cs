using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P26_ReverseTheString
    {
        public void ReverseTheString()
        {
            Console.Write("Enter the string to reverse : ");
            string str = Console.ReadLine();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
