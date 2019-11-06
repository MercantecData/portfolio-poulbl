using System;
using System.Collections.Generic;
using System.Text;

namespace YderligereTræning
{
    public class Person
    {
        private double money;
        private string name;
        private int age;

        public Person(double money, string name, int age)
        {
            this.money = money;
            this.name = name;
            this.age = age;
        }


        public double GetMoney()
        {
            return money;
        }

        public void SetMoney(double money)
        {
            this.money = money;
        }

        public string GetName()
        {
            return name;
        }

        public void SubtractMoney(double money)
        {
            this.money -= money;
        }
        public void AddMoney(double money)
        {
            this.money += money;
        }

    }
}
