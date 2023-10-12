namespace Lab7_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri shape1 = new Cirkel();
            Geometri shape2 = new Fyrkant();
            Geometri shape3 = new Rektangel();
            Geometri shape4 = new Parallellogram();
            Geometri shape5 = new Ellips();
            shape1.Area();
            shape2.Area();
            shape3.Area();
            shape4.Area();
            shape5.Area();
        }
    }
}