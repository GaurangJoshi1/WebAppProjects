using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    class P12_Dictionary
    {
        public void Dictionary()
        {
            Dictionary<string,string> dic = new Dictionary<string,string>();
            Console.WriteLine("P12 : A program that acts as a basic dictionary");

            int n;
            do
            {
                repeat:
                    Console.WriteLine();
                    Console.WriteLine("Select a Option from below");
                    Console.WriteLine("1. Add Word");
                    Console.WriteLine("2. Find Defination of a word");
                    Console.WriteLine("3. Quit the program");
                    Console.WriteLine();
                    Console.Write("Select a Option : ");
                    n = Convert.ToInt32(Console.ReadLine());

                    switch(n)
                    {
                        case 1:
                            Console.Write("Add Word : ");
                            string s = Console.ReadLine();
                            Console.Write("Enter the defination of the word : ");
                            string d = Console.ReadLine();
                            dic.Add(s, d);
                            break;

                        case 2:
                            Console.Write("Enter Word to find defination : ");
                            string word = Console.ReadLine();
                            if (dic.ContainsKey(word))
                            {
                                Console.WriteLine("Defination is : " + dic[word]);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("You have entered the word that is not available in this dictionary");
                                Console.WriteLine();
                            }
                            break;

                        case 3:
                            Console.WriteLine("Exited the Program");
                            return;
                        default:
                            Console.WriteLine("Select Valid Input:");
                            Console.WriteLine();
                            goto repeat;
                            break;

                    }
            }while(true);
        }
    }
}
