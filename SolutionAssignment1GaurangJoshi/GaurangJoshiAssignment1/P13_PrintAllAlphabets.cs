using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P13_PrintAllAlphabets
    {
        public void PrintAllAlphabets()
        {
            for(char chr = 'A'; chr <= 'Z'; chr++)
            {
                Console.Write(chr + " - ");
            }
            Console.WriteLine("\n");
            for (char chr = 'a'; chr <= 'z'; chr++)
            {
                Console.Write(chr + " - ");
            }
        }
    }
}
