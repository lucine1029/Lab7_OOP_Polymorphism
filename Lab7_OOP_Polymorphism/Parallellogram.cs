using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_OOP_Polymorphism
{
    internal class Parallellogram : Geometri
    {
        public int BaseLength { get; set; }
        public int Heigth { get; set; }
        public Parallellogram() 
        { 
            BaseLength = 6;
            Heigth = 10;
        }
        public override double Area()
        {
            area = BaseLength * Heigth * Math.PI;
            Console.WriteLine($"Area {this.GetType().Name} :{area:0.00}");
            return area;
        }
    }
}
