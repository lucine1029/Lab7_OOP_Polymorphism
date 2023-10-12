using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_OOP_Polymorphism
{
    internal class Ellips : Geometri
    {
        public int SemiMajorAxes { get; set; }
        public int SemiMinorAxes { get; set; }
        public Ellips() 
        { 
            SemiMajorAxes = 5;
            SemiMinorAxes = 3;
        }
        public override double Area()
        {
            area = SemiMajorAxes * SemiMinorAxes * Math.PI;
            Console.WriteLine($"Area {this.GetType().Name} :{area:0.00}");
            return area;
        }
    }
}
