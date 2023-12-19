using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.tankCapacity = tankCapacity;
            if (fuelQuantity > this.tankCapacity)
            {
                this.fuelQuantity = 0;
            }
            else
            {
                this.fuelQuantity = fuelQuantity;
                this.fuelConsumption = fuelConsumption + consumptionModifier;
            }
        }

        protected double fuelQuantity;
        protected double fuelConsumption;
        private double consumptionModifier;
        protected double tankCapacity;

        public virtual void Drive(double distance)
        {
            //distance<fuelQuantity*fuelConsumption
            if (fuelQuantity - fuelConsumption * distance > 0)
            {
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
                fuelQuantity -= distance * fuelConsumption;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public virtual void Refuel(double liters)
        {
            if (liters > 0)
            {
                if (liters + fuelQuantity > tankCapacity)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    this.fuelQuantity += liters;
                }
            }
            else
            {
                Console.WriteLine($"Fuel must be a positive number");
            }

        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {fuelQuantity:f2}";
        }
    }
}
