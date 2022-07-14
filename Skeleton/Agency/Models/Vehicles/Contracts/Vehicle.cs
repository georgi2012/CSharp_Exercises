using System;
using System.Collections.Generic;
using System.Text;

namespace Agency.Models.Vehicles.Contracts
{
    public class Vehicle : IVehicle
    {
        protected int passangerCapacity;
        protected VehicleType type;
        protected decimal pricePerKilometer;
        public Vehicle(int pasCapacity, decimal price, VehicleType type)
        {
            if(pasCapacity < 1 || pasCapacity > 800)
            {
                throw new ArgumentException("A vehicle with less than 1 passengers or more than 800 passengers cannot exist!");
            }
            if (price < 0.1m || price > 2.5m)
            {
                throw new ArgumentException("A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!");
            }
            passangerCapacity = pasCapacity;
            pricePerKilometer = price;
            this.type = type;
        }

        public VehicleType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }

        }
        public int PassangerCapacity
        {
            get
            {
                return passangerCapacity;
            }
        }

        public decimal PricePerKilometer
        {
            get
            {
                return pricePerKilometer;
            }
        }


    }
}
