using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    public class Program
    {
        static void Main(string[] args)
        {


            //Program 1
            //P1_ArraySort p1_ArraySort = new P1_ArraySort();
            //p1_ArraySort.ArraySort();

            //Program 2
            //P2_CalculateTheAverageOfArray p2_CalculateTheAverageOfArray = new P2_CalculateTheAverageOfArray();
            //p2_CalculateTheAverageOfArray.CalculateTheAverageOfArray();

            //Program 3
            //P3_MaxAndMinFromArray p3_MaxAndMinFromArray = new P3_MaxAndMinFromArray();
            //p3_MaxAndMinFromArray.MaxAndMinFromArray();

            //Program 4
            //P4_PrintTheArrayForwardAndReverse p4_PrintTheArrayForwardAndReverse = new P4_PrintTheArrayForwardAndReverse();
            //p4_PrintTheArrayForwardAndReverse.PrintTheArrayForwardAndReverse();

            //Program 5
            //P5_LinearSearchInArray p5_LinearSearchInArray = new P5_LinearSearchInArray();
            //p5_LinearSearchInArray.LinearSearchInArray();

            //Program 6
            //P6_PartialEmployee p6_PartialEmployee = new P6_PartialEmployee();
            //p6_PartialEmployee.DisplayBonus();

            //Program 7
            //P7_PartialPerson p7_PartialPerson = new P7_PartialPerson();
            //p7_PartialPerson.displayValidate();

            //Program 8
            //P8_PartialCar p8_PartialCar = new P8_PartialCar
            //{
            //    make = "BMW",
            //    model = "X6",
            //    year = 2022
            //};
            //Console.WriteLine("P8 : Display Properties like Make, Model, and Year using partial class defination with the use of function");
            //Console.WriteLine();
            //p8_PartialCar.DispStartEngine();

            //----------------------------------------------------------------------------------------------------
            //Program 9
            //P9_StudentInfo studentInfo1 = new P9_StudentInfo()
            //{
            //    StudentId = 1,
            //    StudentFName = "Gaurang",
            //    StudentLName = "Joshi",
            //};
            //P9_StudentInfo studentInfo2 = new P9_StudentInfo()
            //{
            //    StudentId = 2,
            //    StudentFName = "Steave",
            //    StudentLName = "Rodger",
            //};
            //P9_StudentInfo studentInfo3 = new P9_StudentInfo()
            //{
            //    StudentId = 3,
            //    StudentFName = "Robert",
            //    StudentLName = "Martin",
            //};

            //List<P9_StudentInfo> StudentList = new List<P9_StudentInfo>();
            //StudentList.Add(studentInfo1);
            //StudentList.Add(studentInfo2);
            //StudentList.Add(studentInfo3);

            //Console.WriteLine("P9 :  Print the properties of class like StudentId, FirstName, and LastName with sorting using List ");
            //Console.WriteLine();

            //foreach(P9_StudentInfo student in StudentList)
            //{
            //    Console.WriteLine("Student Id is : {0}, First Name : {1}, Last Name Is : {2}", student.StudentId, student.StudentFName, student.StudentLName);
            //}
            //StudentList.Sort((s1, s2) => string.Compare(s1.StudentFName, s2.StudentFName));
            //Console.WriteLine();
            //foreach(var student in StudentList)
            //{
            //    Console.WriteLine("Student Id is : {0} First Name : {1} Last Name Is : {2}", student.StudentId, student.StudentFName, student.StudentLName);
            //}
            //----------------------------------------------------------------------------------------------------


            //Program 10
            //P10_ListOfString p10_ListOfString = new P10_ListOfString();
            //p10_ListOfString.ListOfString();

            //Program 11
            //P11_ToDoList p11_ToDoList = new P11_ToDoList();
            //p11_ToDoList.ToDoList();

            //Program 12
            //P12_Dictionary p12_Dictionary = new P12_Dictionary();
            //p12_Dictionary.Dictionary();

            //Program 13
            //P13_StudentsGradeUsingDict p13_StudentsGradeUsingDict=new P13_StudentsGradeUsingDict();
            //p13_StudentsGradeUsingDict.StudentGrade();

            //Program 14
            //P14_EnglishToSpanish p14_EnglishToSpanish = new P14_EnglishToSpanish();
            //p14_EnglishToSpanish.EnglishToSpanish();


            //Program 15
            //P15_BankAccount p15_BankAccount = new P15_BankAccount("1212124334", 1000);
            //try
            //{
            //    p15_BankAccount.Deposite(800);
            //    p15_BankAccount.Withdraw(300);
            //    p15_BankAccount.Withdraw(2000); //Shouls throw exception
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error : " + ex.Message);
            //}
            //-----------------------------------------------------------------------------------------------------

            //Program 16
            P16_AgeValidationUsingExceptionHandling p16_AgeValidationUsingExceptionHandling = new P16_AgeValidationUsingExceptionHandling();
            p16_AgeValidationUsingExceptionHandling.AgeValidationUsingExceptionHandling();

            //Program 17
            //P17_StringToIntUsingExceptionHandling p17_StringToIntUsingExceptionHandling = new P17_StringToIntUsingExceptionHandling();
            //p17_StringToIntUsingExceptionHandling.StringToIntUsingExceptionHandling();

            //------------------------------------------------------------------------------------------------------------
            //Program 18
            //P18_DispStudentUsingGenericClass<int> p18_employee = new P18_DispStudentUsingGenericClass<int>(01, "Gaurang Joshi");
            //P18_DispStudentUsingGenericClass<string> p18_student = new P18_DispStudentUsingGenericClass<string>("E007", "Steaven Rpbert");
            //P18_DispStudentUsingGenericClass<string> p18_customer = new P18_DispStudentUsingGenericClass<string>("C45","Mr Messi");

            //Console.WriteLine("P18 : Display id and name of customer or \r\nemployee or student using generic class defination");
            //Console.WriteLine();
            //Console.Write("Emplopyee Info Is : ");
            //p18_employee.DisplayDetails();
            //Console.WriteLine();

            //Console.Write("Student Info Is : ");
            //p18_student.DisplayDetails();
            //Console.WriteLine();

            //Console.Write("Customer Info Is : ");
            //p18_customer.DisplayDetails();
            //--------------------------------------------------------------------------------------------------------

            //-------------------------------------------------------------------------------------------------------------------------
            //Program 19 
            //P19_KeyValuePairUsingGenericClass<string, double> kv1 = new P19_KeyValuePairUsingGenericClass<string, double>("Balance", 90500000);
            //Console.WriteLine("P19 : Display the key and value using generic class defination that having function");
            //Console.WriteLine();
            //kv1.Display();

            //P19_KeyValuePairUsingGenericClass<int, string> kv2 = new P19_KeyValuePairUsingGenericClass<int, string>(1, "Gaurang Joshi");
            //kv2.Display();

            //P19_KeyValuePairUsingGenericClass<string, char> kv3 = new P19_KeyValuePairUsingGenericClass<string, char>("Grade",'A');
            //kv3.Display();
            //-------------------------------------------------------------------------------------------------------------------------
        }
    }
}
