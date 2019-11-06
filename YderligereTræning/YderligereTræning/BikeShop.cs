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
        }


        public List<Bicycle> GetAllBikes()
        {
            return bikeList;
        }

        public void AddBike(Bicycle bike)
        {
            bikeList.Add(bike);
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
            }
            return brandList;
        }
        
    }
}
