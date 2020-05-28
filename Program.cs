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

            Building Regency = new Building("4004 Regency Drive");
            Regency.Width = 275;
            Regency.Stories = 15;
            Regency.Depth = 85;

            Regency.Construct();
            Regency.Purchase("Hardy & Associates");



            City megalopolis = new City("Megalopolis", "Brian Orchard", 1855);
            megalopolis.AddBuilding(FiveOneTwoEighth);
            megalopolis.AddBuilding(Regency);


            foreach (Building building in megalopolis.Buildings)
            {
                Console.WriteLine();
                Console.WriteLine(building.GetAddress());
                Console.WriteLine("--------------");
                Console.WriteLine(building.GetDesigner());
                Console.WriteLine(building.GetDateConstructed());
                Console.WriteLine(building.GetOwner());
                Console.WriteLine(building.GetVolume());
                Console.WriteLine();
            }





        }
    }
}
