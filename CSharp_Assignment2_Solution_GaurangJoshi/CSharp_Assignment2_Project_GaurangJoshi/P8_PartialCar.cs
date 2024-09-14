using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment2_Project_GaurangJoshi
{
    public partial class P8_PartialCar
    {
        //public string make;
        //public string model;
        //public int year;

        public string make {  get; set; }
        public string model {  get; set; }
        public int year {  get; set; }

        partial void StartEngine();
    }
}
