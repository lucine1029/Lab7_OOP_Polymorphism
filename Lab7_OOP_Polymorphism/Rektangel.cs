using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_OOP_Polymorphism
{
    internal class Rektangel : Geometri
    {
        public int Length { get; set; }
        public int Height { get; set; }
        public Rektangel() 
        { 
            Length = 3;
            Height = 6;
        }
        public override double Area()
        {
            area = Length * Height;
            Console.WriteLine($"Area {this.GetType().Name} :{area:0.00}");
            return area;
        }
    }
}
