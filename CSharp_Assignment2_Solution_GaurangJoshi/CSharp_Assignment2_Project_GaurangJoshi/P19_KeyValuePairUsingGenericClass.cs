using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    class P19_KeyValuePairUsingGenericClass<Tkey,Tvalue>
    {
        private Tkey key;
        private Tvalue value;

        public P19_KeyValuePairUsingGenericClass(Tkey key, Tvalue value)
        {
            this.key = key;
            this.value = value;
        }

        public void Display()
        {
            Console.WriteLine("Key Is : " + key + ", Value Is : " + value);
        }
    }
}
