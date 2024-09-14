using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P3_VowelOrConsonant
    {
        public void VowelOrConsonant() {
            Console.Write("Enter the alphabet to check the number is vowel or consonant: ");
            char char1 =char.Parse(Console.ReadLine());

            if (char1 == 'a' || char1 == 'e' || char1 == 'i' || char1 == 'o' || char1 == 'u') {  
                Console.WriteLine("The aphabet is VOWEL"); 
            }
            else
            {
                Console.WriteLine("The aphabet is CONSONJANT");
            }
        }
    }
}
