using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    public partial class P8_PartialCar
    {
        partial void StartEngine()
        {
            Console.WriteLine("the model name:" + make);
            Console.WriteLine("the year is:" + model);
            Console.WriteLine("the brand maker name:" + year);
            Console.WriteLine();
            Console.WriteLine("Engine Starting");
            Console.WriteLine();
        }

        public void DispStartEngine()
        {
            StartEngine();
        }

    }
}
