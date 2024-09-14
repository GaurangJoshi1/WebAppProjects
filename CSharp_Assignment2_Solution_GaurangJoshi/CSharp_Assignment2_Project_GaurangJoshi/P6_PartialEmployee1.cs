using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    public partial class P6_PartialEmployee
    {
        partial void CalculateBonus()
        {
            Console.Write("Program 6 : Calculate Bonus with the use of partial class defination  ");
            Console.Write("Enter Your Current Salary : ");
            double salary = Convert.ToInt64(Console.ReadLine());
            Console.Write("The Bonus is 10% of your total salary : ");
            double bonus = salary * 0.1;
            Console.WriteLine("Total Bonus is : " + bonus);
            double totalAmount = salary + bonus;
            Console.WriteLine("Total Amount salary plus bonus is : " + totalAmount);
        }

        public void DisplayBonus()
        {
            CalculateBonus();
        }
    }
}
