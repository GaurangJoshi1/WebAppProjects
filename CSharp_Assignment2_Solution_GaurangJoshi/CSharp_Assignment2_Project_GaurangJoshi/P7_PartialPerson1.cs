using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    public partial class P7_PartialPerson
    {
        partial void Validate()
        {
            Console.WriteLine("P7 : Validate the age of function using partial defination");
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 0 && age<150)
            {
                Console.WriteLine("Age is valid");
            }
            else
            {
                Console.WriteLine("Age is Less than Or equal to Zero And greater than 150 that is not valid");
            }
        }
        public void displayValidate()
        {
            Validate();
        }
    }
}
