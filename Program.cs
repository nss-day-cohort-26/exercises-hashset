using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Xterra");
            Showroom.Add("Mustang");
            Showroom.Add("Mini Cooper");
            Showroom.Add("Thunderbird");

            Console.WriteLine($"There are {Showroom.Count} cars in my show room");

            HashSet<string> UsedLot = new HashSet<string>();
            Showroom.Add("F-150");
            Showroom.Add("Thunderbird");

            Showroom.UnionWith(UsedLot);
            Showroom.Remove("Thunderbird");

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Camry");
            Junkyard.Add("Mustang");
            Junkyard.Add("Accord");
            Junkyard.Add("Sable");
            Junkyard.Add("Mini Cooper");
            Junkyard.Add("K-Car");

            HashSet<string> clone = new HashSet<string>(Showroom);
            clone.IntersectWith(Junkyard);

            Console.WriteLine("Cars in common between show room and junk yard:");
            foreach (string car in clone)
            {
                Console.WriteLine($"  {car}");
            }

            Console.WriteLine("Buying all the cars in the junk yard. I now own:");
            Showroom.UnionWith(Junkyard);
            foreach (string car in Showroom)
            {
                Console.WriteLine($"  {car}");
            }

            Console.WriteLine("Selling the Sable. I now own:");
            Showroom.Remove("Sable");
            foreach (string car in Showroom)
            {
                Console.WriteLine($"  {car}");
            }

        }
    }
}
