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

            PoulsCykler.AddBike(new Bicycle("Centurion", 26.5, 3899.95, Color.RED));
            PoulsCykler.AddBike(new Bicycle("Centurion", 27.0, 4899.95, Color.BROWN));
            PoulsCykler.AddBike(new Bicycle("Centurion", 26.0, 3400.00, Color.GREEN));
            PoulsCykler.AddBike(new Bicycle("Look", 28.0, 6999.00, Color.YELLOW));
            PoulsCykler.AddBike(new Bicycle("Look", 18.5, 899.95, Color.CYAN));
            PoulsCykler.AddBike(new Bicycle("Look", 2109310293.5, 353452435899.95, Color.BLUE));
            PoulsCykler.AddBike(new Bicycle("RALEIGH", 27.5, 5999.99, Color.WHITE));
            PoulsCykler.AddBike(new Bicycle("RALEIGH", 27.5, 5999.99, Color.BLACK));
            PoulsCykler.AddBike(new Bicycle("RALEIGH", 27.5, 5999.99, Color.GREY));

            PoulsCyklerRanders.AddBike(new Bicycle("Ribble", 26.5, 1899.95, Color.RED));
            PoulsCyklerRanders.AddBike(new Bicycle("Ribble", 27.0, 1999.95, Color.BROWN));
            PoulsCyklerRanders.AddBike(new Bicycle("Ribble", 26.0, 2400.00, Color.GREEN));
            PoulsCyklerRanders.AddBike(new Bicycle("Canyon", 22.0, 999.00, Color.YELLOW));
            PoulsCyklerRanders.AddBike(new Bicycle("Canyon", 18.5, 699.95, Color.CYAN));
            PoulsCyklerRanders.AddBike(new Bicycle("Canyon", 42.0, 133.7, Color.BLUE));
            PoulsCyklerRanders.AddBike(new Bicycle("Radon", 27.5, 3999.99, Color.WHITE));
            PoulsCyklerRanders.AddBike(new Bicycle("Radon", 27.5, 3999.99, Color.BLACK));
            PoulsCyklerRanders.AddBike(new Bicycle("Radon", 27.5, 3999.99, Color.GREY));


            PoulsEmporium.bikeShops.Add(PoulsCykler);
            PoulsEmporium.bikeShops.Add(PoulsCyklerRanders);

            Console.WriteLine("All brands available:");
            List<string> brands = PoulsCykler.GetAllBrands();
            brands.AddRange(PoulsCyklerRanders.GetAllBrands());

            foreach (string str in brands)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\n\n\nSkriv et mærke du vil finde cykler fra.");
            string input = Console.ReadLine();
            PoulsCykler.GetAllBicyclesOfBrand(input);
            PoulsCyklerRanders.GetAllBicyclesOfBrand(input);

            Console.WriteLine("\n\n\nRed bikes amount");
            PoulsEmporium.ReturnBikeAmountFromColor(Color.RED);






        }
    }
}
