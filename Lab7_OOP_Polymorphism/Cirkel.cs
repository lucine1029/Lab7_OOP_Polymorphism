using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_OOP_Polymorphism
{
    internal class Cirkel : Geometri
    {
        public double Radius { get; set; }
        public Cirkel() 
        { 
            Radius = 5;
        }
        public override double Area()
        {
            area = Math.Pow(Radius, 2) * Math.PI;
            Console.WriteLine($"Area {this.GetType().Name} :{area:0.00}");
            return area;
        }
    }
}
