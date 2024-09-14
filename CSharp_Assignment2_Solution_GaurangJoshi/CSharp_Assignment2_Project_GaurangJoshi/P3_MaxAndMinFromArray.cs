using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
     public class P3_MaxAndMinFromArray
    {
        public void MaxAndMinFromArray()
        {
            Console.WriteLine("P3 : Find the maximum and minimum values in an array of integers");
            Console.WriteLine();

            Console.Write("Enter the size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Please Enter the " + n + " elements of array : ");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int max = array[0]; 
            int min = array[0];

            for(int i = 0;i < n; i++)
            {
                if (array[i] > max) 
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("The Maximum value in array is : " + max);
            Console.WriteLine("The Minimun value in array is : " + min);

        }
    }
}
