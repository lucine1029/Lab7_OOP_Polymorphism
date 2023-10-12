using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_OOP_Polymorphism
{
    internal class Fyrkant : Geometri
    {
        public int BaseLength { get; set; }
        public Fyrkant() 
        { 
            BaseLength = 6;
        }
        public override double Area()
        {
            area = BaseLength * BaseLength;
            Console.WriteLine($"Area {this.GetType().Name} :{area:0.00}");
            return area;
        }
    }
}
