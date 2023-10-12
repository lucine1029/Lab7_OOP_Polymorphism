using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_OOP_Polymorphism
{
    internal class Geometri
    {
        public double area;
        public virtual double Area()
        {
            return  area;
        }
    }
}
