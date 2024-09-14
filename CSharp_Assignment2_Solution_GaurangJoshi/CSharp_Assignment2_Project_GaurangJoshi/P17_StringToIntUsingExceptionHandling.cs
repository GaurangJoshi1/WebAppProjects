using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    class P17_StringToIntUsingExceptionHandling
    {
        public void StringToIntUsingExceptionHandling()
        {
            Console.WriteLine("P17 : program that reads user input and performs converting a string to \r\nan integer Using Exception Handling");
            Console.WriteLine();
            
                Console.Write("Enter a Number : ");
                string str = Console.ReadLine();
                try
                {
                    int number = Convert.ToInt32(str);
                    Console.WriteLine("The number you have entered is : " +number);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please Enter Valid Interger Number");
                    
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number you have entered is too large or small");
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There is error in the input please enter valid interger");
                    
            }
        }
    }
}
