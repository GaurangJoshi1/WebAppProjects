using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P27_FindUniqueCharactersInString
    {
        public void FindUniqueCharactersInString()
        {
            Console.Write("Enter the string for finding unique characters : ");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    
                    if (str[i] == str[j] && i != j)    // checking if two characters are equal
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    Console.Write(str[i]);
            }
        }
    }
}
