using System;
using System.Collections.Generic;
using System.Text;

namespace YderligereTræning
{
    public class Emporium
    {

        public List<BikeShop> bikeShops = new List<BikeShop>();

        public Emporium()
        {
        }

        public int ReturnBikeAmountFromColor(Color color)
        {
            int totalBikesOfColor = 0;
            Console.WriteLine("Color chosen: " + color);
            foreach (BikeShop shop in bikeShops)
            {
                foreach (Bicycle bike in shop.GetAllBikes())
                {
                    if(bike.GetColor() == color)
                    {
                        totalBikesOfColor++;
                    }
                
                }
            }
            Console.WriteLine(color + " bikes found: " + totalBikesOfColor);
            return totalBikesOfColor;
        }
    }
}
