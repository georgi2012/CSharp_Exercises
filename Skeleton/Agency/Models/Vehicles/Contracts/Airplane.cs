using System;
using System.Collections.Generic;
using System.Text;

namespace Agency.Models.Vehicles.Contracts
{
    public class Airplane : Vehicle, IAirplane
    {
        public bool hasFreeFood;

        public bool HasFreeFood
        {
            get
            {
                return hasFreeFood;
            }
        }

        public Airplane(int pasCapacity, decimal price, bool hasFreeFood)
            : base(pasCapacity, price, VehicleType.Air)
        {
            this.hasFreeFood = hasFreeFood;
        }

        public override string ToString()
        {
            return "Airplane ----\n" +
                   $"Passenger capacity: {passangerCapacity}\n" +
                   $"Price per kilometer: {pricePerKilometer}\n" +
                   $"Vehicle type: {type.ToString()}\n" +
                   $"Has free food: {hasFreeFood}";
        }
    }
}
