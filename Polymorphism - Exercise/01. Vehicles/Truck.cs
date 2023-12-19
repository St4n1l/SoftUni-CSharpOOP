using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
   public class Truck : Vehicle
   {
       private const double consumptionModifier = 1.6;
       public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + consumptionModifier)
       {
       }

       public override void Refuel(double liters)
       {
           base.Refuel(liters * 0.95);
       }
   }
}
