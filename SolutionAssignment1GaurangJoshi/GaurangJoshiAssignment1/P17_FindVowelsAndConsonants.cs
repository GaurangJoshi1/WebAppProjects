using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P17_FindVowelsAndConsonants
    {
        public void FindVowelsAndConsonants()
        {
            Console.Write("Enter the number to find vowels, consonants and spaces :");
            string str = Console.ReadLine();
            int vowels = 0, consonant = 0, spaceschar = 0;

            // str.length() function to count number of 
            // character in given string. 
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if ((ch >= 'a' && ch <= 'z') ||
                    (ch >= 'A' && ch <= 'Z'))
                {

                    // To handle upper case letters 
                    ch = char.ToLower(ch);

                    if (ch == 'a' || ch == 'e' || ch == 'i' ||
                        ch == 'o' || ch == 'u')
                        vowels++;
                    else
                        consonant++;
                }
                else
                {
                    spaceschar++;
                }
            }
            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonant: " + consonant);
            Console.WriteLine("spaces : " + spaceschar);
        }
    }
}
