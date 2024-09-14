using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P25_CalculateSimpleInterest
    {
        public void CalculateSimpleInterest()
        {
            Console.Write("Enter principle value : ");
            double principle = Double.Parse(Console.ReadLine());
            Console.Write("Enter Rate: ");
            double rate = Double.Parse(Console.ReadLine());
            Console.Write("Enter time  : ");
            double time = Double.Parse(Console.ReadLine());

            double SI = (principle * rate * time) / 100;
            Console.WriteLine("Simple interest is: " + SI);
        }
    }
}
