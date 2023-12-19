using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption + consumptionModifier;
        }

        private double fuelQuantity;
        private double fuelConsumption;
        private double refuelModifier;
        private double consumptionModifier;

        public virtual void Drive(double distance)
        {
            //distance<fuelQuantity*fuelConsumption
            if (fuelQuantity-fuelConsumption*distance>0)
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
            this.fuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {fuelQuantity:f2}";
        }
    }
}
