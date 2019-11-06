using System;
using System.Collections.Generic;
using System.Text;

namespace YderligereTræning
{
    class BikeShop
    {
        List<Bicycle> bikeList = new List<Bicycle>();


        BikeShop()
        {
            bikeList.Add(new Bicycle("Centurion", 26.5, 3899.95, Color.RED));
            bikeList.Add(new Bicycle("Centurion", 27.0, 4899.95, Color.BROWN));
            bikeList.Add(new Bicycle("Centurion", 26.0, 3400.00, Color.GREEN));
            bikeList.Add(new Bicycle("Look", 28.0, 6999.00, Color.YELLOW));
            bikeList.Add(new Bicycle("Look", 18.5, 899.95, Color.CYAN));
            bikeList.Add(new Bicycle("Look", 2109310293.5, 353452435899.95, Color.BLUE));
            bikeList.Add(new Bicycle("RALEIGH", 27.5, 5999.99, Color.WHITE));
            bikeList.Add(new Bicycle("RALEIGH", 27.5, 5999.99, Color.BLACK));
            bikeList.Add(new Bicycle("RALEIGH", 27.5, 5999.99, Color.GREY));
        }

        List<Bicycle> GetAllBicyclesOfBrand(string brand)
        {
            List<Bicycle> brandList = new List<Bicycle>();
            for (int i = 0; i < bikeList.Count; i++)
            {
                if(brand.ToLower().Trim() == bikeList[i].GetBrand().ToLower().Trim())
                {
                    brandList.Add(bikeList[i]);
                }
            }
            if (brandList.Count > 0)
            {
                Console.WriteLine("Brand found.");
            }
            else
            {
                Console.WriteLine("Brand not found.");
            }
            return brandList;
        }
        
    }
}
