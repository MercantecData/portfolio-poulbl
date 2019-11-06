using System;
using System.Collections.Generic;
using System.Text;

namespace YderligereTræning
{

    public enum Color { RED, GREEN, YELLOW, BLUE, ORANGE, PURPLE, CYAN, BROWN, BLACK, WHITE, SILVER, GREY }

    public class Bicycle
    {
        private string brand;
        private double wheelSize;
        private Color color;
        private double price;
        private BikeShop owningStore;

        public Bicycle(string brand, double wheelSize, double price, Color color, BikeShop owningStore)
        {
            this.brand = brand;
            this.wheelSize = wheelSize;
            this.price = price;
            this.color = color;
            this.owningStore = owningStore;
        }
        public double GetWheelSize()
        {
            return wheelSize;
        }

        public BikeShop GetOwningStore()
        {
            return owningStore;
        }

        public Color GetColor()
        {
            return color;
        }

        public double GetPrice()
        {
            return price;
        }

        public void PrintBikeInformation(int index)
        {
            Console.WriteLine("Index: " + index + " - Brand: " + brand + " - WheelSize: " + wheelSize + " - Price: " + price + " - Color: " + color.ToString());
        }

        public string GetBrand()
        {
            return brand;
        }
    }


}
