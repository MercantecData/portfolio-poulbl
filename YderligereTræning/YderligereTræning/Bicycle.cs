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

        public Bicycle(string brand, double wheelSize, double price, Color color)
        {
            this.brand = brand;
            this.wheelSize = wheelSize;
            this.price = price;
            this.color = color;
        }
        public double GetWheelSize()
        {
            return wheelSize;
        }

        public Color GetColor()
        {
            return color;
        }

        public void PrintBikeInformation()
        {
            Console.WriteLine("Brand: " + brand + " - WheelSize: " + wheelSize + " - Price: " + price + " - Color: " + color.ToString());
        }

        public string GetBrand()
        {
            return brand;
        }
    }


}
