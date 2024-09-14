using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    class P16_AgeValidationUsingExceptionHandling
    {
        public void AgeValidationUsingExceptionHandling()
        {
            int age;
            Console.WriteLine("P16 : Age validation Using Exception Handling ");
            Console.WriteLine();
            try
            {
                Console.Write("Enter Your Age : ");
                age = Convert.ToInt32(Console.ReadLine());
                if(age < 0 || age>150)
                {
                    Console.WriteLine("Age Can not be less than ZeroOr Greater than 150");
                }
                else
                {
                    Console.WriteLine("Your Age is : " + age);
                }
            }
            catch (FormatException) 
            { 
            Console.WriteLine("Invalid Input.Please Enter a Valid numeric value for age. ");
            }
            catch(OverflowException) 
            {
                Console.WriteLine("Invalid Input. Age value is too large.");
            }
        }
    }
}
