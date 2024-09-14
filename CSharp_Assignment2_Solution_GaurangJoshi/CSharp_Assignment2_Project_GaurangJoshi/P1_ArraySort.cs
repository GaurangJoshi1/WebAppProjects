using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    public class P1_ArraySort
    {
        public void ArraySort()
        {
            Console.WriteLine("P1 : Sorting Of The Array");
            Console.WriteLine();
            Console.WriteLine("Enter a list of numbers seperated by spaces : ");
            string num1 = Console.ReadLine();

            string[] array = num1.Split(' ');

            // Conver String of numbers into array of numbers
            int[] arr= new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                arr[i] = int.Parse(array[i]);
            }
            Array.Sort(arr);

            Console.WriteLine("The Sorted Array is : ");
            foreach(int i in arr)
            {
                Console.Write(i);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
