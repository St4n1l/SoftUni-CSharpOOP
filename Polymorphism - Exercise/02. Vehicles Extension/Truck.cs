using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double consumptionModifier = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption + consumptionModifier, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            if (liters>0)
            {
                if (liters*0.95 + base.fuelQuantity < base.tankCapacity)
                {
                    base.Refuel(liters * 0.95);
                }
                else
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
            }
            else
            {
                Console.WriteLine($"Fuel must be a positive number");
            }
        }
    }
}
