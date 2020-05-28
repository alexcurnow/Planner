using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEighth = new Building("512 8th Avenue");
            FiveOneTwoEighth.Width = 300;
            FiveOneTwoEighth.Stories = 20;
            FiveOneTwoEighth.Depth = 100;
            FiveOneTwoEighth.Construct();
            FiveOneTwoEighth.Purchase("Charles & Whentworth Llc");

            Console.WriteLine(FiveOneTwoEighth.GetAddress());
            Console.WriteLine("--------------");
            Console.WriteLine(FiveOneTwoEighth.GetDesigner());
            Console.WriteLine(FiveOneTwoEighth.GetDateConstructed());
            Console.WriteLine(FiveOneTwoEighth.GetOwner());
            Console.WriteLine(FiveOneTwoEighth.GetVolume());





        }
    }
}
