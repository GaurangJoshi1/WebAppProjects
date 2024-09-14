using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    public class P2_CalculateTheAverageOfArray
    {
        public void CalculateTheAverageOfArray()
        {
            Console.WriteLine("P2 : Calculates the average of a given array of floating-point numbers");
            Console.WriteLine();

            Console.Write("Enter the size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            float[] array = new float[n];
            Console.WriteLine("Please Enter the " + n + " elements of array : ");

            for(int i = 0; i < n; i++)
            {
                array[i] = float.Parse(Console.ReadLine());
            }
            float sum = 0;
            for(int i = 0;i < n; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine("The average of all floating point numbers is : " + (sum / n));
        }
    }
}
