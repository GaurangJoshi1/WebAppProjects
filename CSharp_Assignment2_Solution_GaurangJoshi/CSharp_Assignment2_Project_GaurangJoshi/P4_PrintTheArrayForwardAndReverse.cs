using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    class P4_PrintTheArrayForwardAndReverse
    {
        public void PrintTheArrayForwardAndReverse()
        {
            Console.WriteLine("P4 : Printing the elements of an array in forward and reverse order");
            Console.WriteLine();

            Console.Write("Enter the size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Please Enter the " + n + " elements of array : ");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Array Printing in forward order using foreach loop
            Console.WriteLine();
            Console.WriteLine("Array Printing in forward order using foreach loop : ");
            foreach (int i in array)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            //Array Printing in forward order using for loop
            Console.WriteLine();
            Console.WriteLine("Array Printing in forward order using for loop : ");
            for(int i = 0;i < n; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }

            //Array Printing in Reverse order using foreach loop
            Console.WriteLine();
            Console.WriteLine("Array Printing in Reverse order using foreach loop : ");
            Array.Reverse(array);
            foreach (int i in array)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Array.Reverse(array);

            //Array Printing in Reverse order using for loop
            Console.WriteLine();
            Console.WriteLine("Array Printing in Reverse order using for loop : ");
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }
    }
}
