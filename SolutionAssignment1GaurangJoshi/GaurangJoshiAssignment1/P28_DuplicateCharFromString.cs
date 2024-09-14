using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P28_DuplicateCharFromString
    {
        public void DuplicateCharFromString()
        {
            Console.Write("Enter The String to Find Duplicate characters:");
            string str1 = Console.ReadLine();
            char[] char1 = str1.ToCharArray();
            Console.Write("Duplicate charactres in the string are: ");
            for (int i = 0; i < char1.Length; i++)
            {
                for (int j = i + 1; j < char1.Length; j++)
                {
                    if (char1[i] == char1[j])
                    {
                        Console.Write(char1[i] + " ");
                        break;
                    }
                }

            }
        }
    }
}
