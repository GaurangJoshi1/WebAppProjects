using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    public class P13_StudentsGradeUsingDict
    {
        static Dictionary<string,string> dic = new Dictionary<string, string>();

        public void StudentGrade()
        {
            Console.WriteLine("P13 : Program that keeps track of student grades");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Select choice from below : ");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Quit the program");
                Console.WriteLine();
                Console.Write("Select a Option : ");

                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        AddStudent();
                        break;

                    case 2:
                        UpdateStudent();
                        break;

                    case 3:
                        DisplayStudent();
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Program Exited");
                        return;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Enter Valid Input");
                        Console.WriteLine();
                        break;
                }
            }while(true);
        }
        public void AddStudent()
        {
            Console.Write("Enter a Student Name : ");
            string name = Console.ReadLine();

            if(dic.ContainsKey(name))
            {
                Console.WriteLine("Student is already added in grade list");
            }
            else
            {
                Console.WriteLine("Enter a grade : ");
                string grade = Console.ReadLine();
                dic.Add(name, grade);
            }
        }
        
        public void UpdateStudent()
        {
            Console.Write("Enter the student name to update a grade : ");
            string name = Console.ReadLine();
            if(dic.ContainsKey(name))
            {
                Console.Write("Enter the updated grade : ");
                string grade = Console.ReadLine();
                dic[name] = grade;
            }
            else
            {
                Console.WriteLine("Student not found in dict");
            }
        }

        public void DisplayStudent()
        {
            foreach(var  student in dic) 
            { 
            Console.WriteLine("Student Name is :"+student.Key + " "+"Grade is  "+student.Value);
            }
        }
    }
}
