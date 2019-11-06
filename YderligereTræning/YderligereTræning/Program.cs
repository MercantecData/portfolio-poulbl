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
            Person buyer = new Person(5000.00, "Korsten", 69);

            PoulsCykler.AddBike(new Bicycle("Centurion", 26.5, 3899.95, Color.RED, PoulsCykler));
            PoulsCykler.AddBike(new Bicycle("Centurion", 27.0, 4899.95, Color.BROWN, PoulsCykler));
            PoulsCykler.AddBike(new Bicycle("Centurion", 26.0, 3400.00, Color.GREEN, PoulsCykler));
            PoulsCykler.AddBike(new Bicycle("Look", 28.0, 6999.00, Color.YELLOW, PoulsCykler));
            PoulsCykler.AddBike(new Bicycle("Look", 18.5, 899.95, Color.CYAN, PoulsCykler));
            PoulsCykler.AddBike(new Bicycle("Look", 2109310293.5, 353452435899.95, Color.BLUE, PoulsCykler));
            PoulsCykler.AddBike(new Bicycle("RALEIGH", 27.5, 5999.99, Color.WHITE, PoulsCykler));
            PoulsCykler.AddBike(new Bicycle("RALEIGH", 27.5, 5999.99, Color.BLACK, PoulsCykler));
            PoulsCykler.AddBike(new Bicycle("RALEIGH", 27.5, 5999.99, Color.GREY, PoulsCykler));

            PoulsCyklerRanders.AddBike(new Bicycle("Ribble", 26.5, 1899.95, Color.RED, PoulsCyklerRanders));
            PoulsCyklerRanders.AddBike(new Bicycle("Ribble", 27.0, 1999.95, Color.BROWN, PoulsCyklerRanders));
            PoulsCyklerRanders.AddBike(new Bicycle("Ribble", 26.0, 2400.00, Color.GREEN, PoulsCyklerRanders));
            PoulsCyklerRanders.AddBike(new Bicycle("Canyon", 22.0, 999.00, Color.YELLOW, PoulsCyklerRanders));
            PoulsCyklerRanders.AddBike(new Bicycle("Canyon", 18.5, 699.95, Color.CYAN, PoulsCyklerRanders));
            PoulsCyklerRanders.AddBike(new Bicycle("Canyon", 42.0, 133.7, Color.BLUE, PoulsCyklerRanders));
            PoulsCyklerRanders.AddBike(new Bicycle("Radon", 27.5, 3999.99, Color.WHITE, PoulsCyklerRanders));
            PoulsCyklerRanders.AddBike(new Bicycle("Radon", 27.5, 3999.99, Color.BLACK, PoulsCyklerRanders));
            PoulsCyklerRanders.AddBike(new Bicycle("Radon", 27.5, 3999.99, Color.GREY, PoulsCyklerRanders));


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
            List<Bicycle> bikesToBuy = PoulsCykler.GetAllBicyclesOfBrand(input);
            bikesToBuy.AddRange(PoulsCyklerRanders.GetAllBicyclesOfBrand(input));

            int i = 0;
            foreach(Bicycle bike in bikesToBuy)
            {
                i++;
                bike.PrintBikeInformation(i);
            }
            Console.WriteLine("\n\n\nRed bikes amount");
            PoulsEmporium.ReturnBikeAmountFromColor(Color.RED);
            
            Console.WriteLine("Pick a bike to buy from index");
            input = Console.ReadLine();
            if(Int32.TryParse(input, out int j))
            {
                if (bikesToBuy[j - 1].GetOwningStore().SellBike(bikesToBuy[j - 1], buyer))
                {
                    Console.WriteLine("CONGRATULATIONS! BICYCLE SUCCESFULLY BOUGHT. NICE!");
                    bikesToBuy.Remove(bikesToBuy[j - 1]);
                }
                else
                {
                    Console.WriteLine(buyer.GetName() + " doesn't have enough money to buy that!");
                }
            }
            Console.WriteLine("\n\n\n");
             i = 0;
            foreach (Bicycle bike in bikesToBuy)
            {
                i++;
                bike.PrintBikeInformation(i);
            }
        }
    }
}
