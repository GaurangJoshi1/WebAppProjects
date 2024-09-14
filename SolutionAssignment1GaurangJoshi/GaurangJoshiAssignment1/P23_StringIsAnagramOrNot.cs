using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GaurangJoshiAssignment1
{
    class P23_StringIsAnagramOrNot
    {
        public void StringIsAnagramOrNot()
        {
            Console.Write("Enter the first string : ");
            string first = Console.ReadLine();
            Console.Write("Enter the second string : ");
            string second = Console.ReadLine();
            bool result = false;

            string str1 = first.ToLower();
            string str2 = second.ToLower();

            if(first.Length == second.Length)
            {
                char[] chrArray1 = str1.ToCharArray();
                char[] chrArray2 = str2.ToCharArray();

                result = true;

                Array.Sort(chrArray1);
                Array.Sort(chrArray2);

                if(chrArray1 == chrArray2)
                {
                    result = true;
                }
            }

            Console.WriteLine("\n");
            if(result == true)
            {
                Console.Write("Strings are Anagram ");
            }
            else
            {
                Console.Write("Strings are NOT Anagram ");

            }
        }
    }
}
