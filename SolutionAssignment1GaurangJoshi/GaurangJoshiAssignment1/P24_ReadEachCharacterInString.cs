using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P24_ReadEachCharacterInString
    {
        public void ReadEachCharacterInString()
        {
            Console.Write("Enter the string : ");
            string str = Console.ReadLine();
            char[] StrArr = str.ToCharArray();
            for (int i = 0; i < StrArr.Length; i++)
            {
                Console.WriteLine(StrArr[i] + " ");
            }
        }
    }
}
