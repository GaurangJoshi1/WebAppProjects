using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    public class P11_ToDoList
    {
        public void ToDoList()
        {
            List<string> list = new List<string>();
            Console.WriteLine("P11 : Program that simulates a to-do list. Allow the user to add, remove, and display tasks \r\nusing a List.");
            Console.WriteLine();

            while (true)
            {
                repeat:
                    Console.WriteLine("1. Add a task");
                    Console.WriteLine("2. Remove a task");
                    Console.WriteLine("3. Show all task");
                    Console.WriteLine("4. Close the list");

                    Console.Write("Select One Option:");
                    int n = Convert.ToInt32(Console.ReadLine());

                    switch(n)
                    {
                        case 1:
                            Console.WriteLine("Enter a task : ");
                            string task = Console.ReadLine();
                            list.Add(task);
                            break;

                        case 2:
                            if (list.Count == 0) 
                            {
                                Console.WriteLine("No task task is added in the list to remove");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("list down task is in the list.");
                                for (int i = 0; i < list.Count; i++)
                                {
                                    Console.WriteLine((i + 1) + " : " + list[i]);
                                }
                                Console.WriteLine("Select a task number to delete that task");
                                int rem = Convert.ToInt32(Console.ReadLine());
                                for (int i = 0;i < list.Count; i++)
                                {
                                    if((rem - 1) == i)
                                    {
                                        list.RemoveAt(i);
                                        Console.WriteLine("The task is deleted");
                                        Console.WriteLine();
                                    }
                                }
                            }
                            break;

                        case 3:
                            if (list.Count == 0)
                            {
                                Console.WriteLine("No Task is added Yet");
                            }
                            else
                            {
                                for (int i = 0; i < list.Count; i++)
                                {
                                    Console.WriteLine((i + 1) + " : "+ list[i]);
                                }
                            }
                            Console.WriteLine();
                            break;

                        case 4:
                            Console.WriteLine("Exited the program");
                            return;

                        default :
                            Console.WriteLine("Invalid Number input. Please select valid input");
                            goto repeat;
                            break;


                    }
            }
        }
    }
}
