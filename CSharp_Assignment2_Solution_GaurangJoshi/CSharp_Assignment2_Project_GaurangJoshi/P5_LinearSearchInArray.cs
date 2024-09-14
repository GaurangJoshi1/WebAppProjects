using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    class P5_LinearSearchInArray
    {
        public void LinearSearchInArray()
        {
            Console.WriteLine("P5 : Linear search to find a specific element in an array");
            Console.WriteLine();

            Console.Write("Enter the size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Please Enter the " + n + " elements of array : ");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Enter the number to get the position of the element : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0;i < n; i++)
            {
                if (array[i] == num)
                {
                    Console.WriteLine("Element is stored at " + i + "number");
                }  
            }
        }
    }
}
