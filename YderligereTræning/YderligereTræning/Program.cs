using System;
using System.Collections.Generic;

namespace YderligereTræning
{
    class Program
    {
        static void Main(string[] args)
        {
            Emporium PoulsEmporium = new Emporium();
            BikeShop PoulsCykler = new BikeShop();
            BikeShop PoulsCyklerRanders = new BikeShop();

            PoulsEmporium.bikeShops.Add(PoulsCykler);
            PoulsEmporium.bikeShops.Add(PoulsCyklerRanders);

            Console.WriteLine("All brands available:");
            List<string> brands = PoulsCykler.GetAllBrands();

            foreach (string str in brands)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\n\n\nSkriv et mærke du vil finde cykler fra.");

            PoulsCykler.GetAllBicyclesOfBrand(Console.ReadLine());

            Console.WriteLine("\n\n\nRed bikes amount");
            PoulsEmporium.ReturnBikeAmountFromColor(Color.RED);






        }
    }
}
