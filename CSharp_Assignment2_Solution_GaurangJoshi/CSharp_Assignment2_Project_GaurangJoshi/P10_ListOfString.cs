using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    public class P10_ListOfString
    {
        public void ListOfString()
        {
            Console.WriteLine("P10 : A program that reads a sentence from the user, splits it into words, and adds each word to \r\na List of strings");
            Console.WriteLine("It Does Operation such AS  : \n1. Prints the number of words in the list.\n2. Removes any duplicate words.\n3. Prints the modified list.\r\n");
            Console.WriteLine();

            Console.Write("Enter A Sentence : ");
            string str = Console.ReadLine();

            string[] arr = str.Split(' '); 

            List<string> list = new List<string>();
            foreach (string item in arr)
            {
                if(!list.Contains(item))
                {
                    list.Add(item);
                }
            }

            Console.WriteLine("Number of words in a list is : "+list.Count);
            Console.WriteLine("Unique elements in a list is : ");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
