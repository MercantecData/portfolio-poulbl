using System;
using System.Collections.Generic;
using System.Text;

namespace YderligereTræning
{
    public class BikeShop
    {
        public List<Bicycle> bikeList;


        public BikeShop()
        {
            bikeList = new List<Bicycle>();
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


        public List<Bicycle> GetAllBikes()
        {
            return bikeList;
        }

        public List<Bicycle> GetBikesWithLargerWheelSize(double size)
        {
            List<Bicycle> bikesToReturn = new List<Bicycle>();
            foreach (Bicycle bike in bikeList)
            {
                if(bike.GetWheelSize() >= size)
                {
                    bikesToReturn.Add(bike);
                }
            }
            return bikesToReturn;
        }

        public List<Bicycle> GetBikesWithSmallerWheelSize(double size)
        {
            List<Bicycle> bikesToReturn = new List<Bicycle>();
            foreach (Bicycle bike in bikeList)
            {
                if (bike.GetWheelSize() <= size)
                {
                    bikesToReturn.Add(bike);
                }
            }
            return bikesToReturn;
        }



        public List<string> GetAllBrands()
        {
            List<string> brands = new List<string>();
            foreach (Bicycle bike in bikeList)
            {
                if(!brands.Contains(bike.GetBrand()))
                {
                    brands.Add(bike.GetBrand());
                }
                else
                {
                    // her skal der ikke være noget
                }

            }
            return brands;
        }

        public List<Bicycle> GetAllBicyclesOfBrand(string brand)
        {
            List<Bicycle> brandList = new List<Bicycle>();
            for (int i = 0; i < bikeList.Count; i++)
            {
                if(brand.ToLower().Trim() == bikeList[i].GetBrand().ToLower().Trim())
                {
                    brandList.Add(bikeList[i]);
                    bikeList[i].PrintBikeInformation();
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
