using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    class P18_DispStudentUsingGenericClass<T>
    {
        private T id;
        private string name;

        public P18_DispStudentUsingGenericClass(T id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Id : " + id + "  Name : " + name);
        }
    }
}
