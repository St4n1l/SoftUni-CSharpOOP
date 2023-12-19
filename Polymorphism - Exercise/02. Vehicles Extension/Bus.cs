using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double fuelConsumptionIncrease = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity,
            fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            base.fuelConsumption += fuelConsumptionIncrease;
            base.Drive(distance);
            base.fuelConsumption -= fuelConsumptionIncrease;
        }

        public void DriveEmpty(double distance)
        {
           base.Drive(distance);
        }
    }
}
