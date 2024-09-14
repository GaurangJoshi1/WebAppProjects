using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P16_PalindromeOrNot
    {
        public void PalindromeOrNot()
        {
            Console.Write("Enter the string to check palindrome or not : ");
            string str = Console.ReadLine();
            Boolean flag = true;

            //Converts the given string into lowercase  
            str = str.ToLower();

            //Iterate the string forward and backward, compare one character at a time   
            //till middle of the string is reached  
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                Console.WriteLine("Given string is palindrome");
            else
                Console.WriteLine("Given string is not a palindrome");
        }
    }
}
