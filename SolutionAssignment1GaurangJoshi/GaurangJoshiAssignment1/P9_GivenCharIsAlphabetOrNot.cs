using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P9_GivenCharIsAlphabetOrNot
    {
        public void GivenCharIsAlphabetOrNot()
        {
            Console.Write("Enter the character to check is alphabet or not: ");
            char char1 = Convert.ToChar(Console.ReadLine());
            if ((char1 >= 'a' && char1 <= 'z') || (char1 >= 'A' && char1 <= 'Z'))
            {
                Console.WriteLine("It is Alphabet");
            }
            else
            {
                Console.WriteLine("It is NOT Alphabet");

            }
        }
    }
}
