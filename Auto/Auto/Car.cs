using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
   public class Car
    {
        public string Brand { get; set; }
        public int Fuel { get; set; }
        public int MaxSpeed { get; set; }
       

        public Car(string brand, int fuel, int maxSpeed)
        {
            Brand = brand;
            Fuel = fuel;
            MaxSpeed = maxSpeed;
        }

        public void Refuel(int amount)
        {
            Fuel += amount;
        }
    }
}
