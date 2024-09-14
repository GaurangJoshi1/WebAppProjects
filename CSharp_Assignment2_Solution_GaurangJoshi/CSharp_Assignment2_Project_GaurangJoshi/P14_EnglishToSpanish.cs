using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    public class P14_EnglishToSpanish
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            {"English 1" , "Spanish 1" },
            {"English 2" , "Spanish 2" },
            {"English 3" , "Spanish 3" },
            {"English 4" , "Spanish 4" },
            {"English 5" , "Spanish 5" },
            {"English 6" , "Spanish 6" },
            {"English 7" , "Spanish 7" },
            {"English 8" , "Spanish 8" },
        };

        public void EnglishToSpanish()
        {
            Console.WriteLine("P14 : English-to-Spanish translation tool Using Dictionaries");
            Console.WriteLine();

            Console.Write("Enter a word to translations into spanish : ");
            string w = Console.ReadLine();
            if (dic.ContainsKey(w))
            {
                Console.WriteLine("Spanish Translation Is : "+dic[w]);
            }
        }
    }
}
