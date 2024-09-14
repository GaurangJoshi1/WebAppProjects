using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaurangJoshiAssignment1
{
    class P22_BasicCalculatorUsingSwitchCase
    {
        public void BasicCalculatorUsingSwitchCase()
        {
            Console.Write("Enter an operator (+, -, *, /): ");
            char oprtr = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter two operands: ");
            double first = Convert.ToInt64(Console.ReadLine());
            double second = Convert.ToInt64(Console.ReadLine());

            switch (oprtr)
            {
                case '+':
                    Console.WriteLine($"{first} + {second} = {first + second}");
                    break;
                case '-':
                    Console.WriteLine($"{first} - {second} = {first - second}");
                    break;
                case '*':
                    Console.WriteLine($"{first} * {second} = {first * second}");
                    break;
                case '/':
                    Console.WriteLine($"{first} / {second} = {first / second}");
                    break;
                // operator doesn't match any case constant
                
                default:
                    Console.WriteLine("Operator is not there");
                    break;
            }
        }
    }
}
