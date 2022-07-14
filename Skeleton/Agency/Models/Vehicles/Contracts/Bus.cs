using System;
using System.Collections.Generic;
using System.Text;

namespace Agency.Models.Vehicles.Contracts
{
    public class Bus : Vehicle, IBus
    {
        public Bus(int pasCapacity, decimal price)
            :base(pasCapacity, price, VehicleType.Land)
        {
            if (pasCapacity < 10 || pasCapacity > 50)
            {
                throw new ArgumentException("A bus cannot have less than 10 passengers or more than 50 passengers.");
            }
        
        }

        public override string ToString()
        {
            return "Bus ----\n" +
                   $"Passenger capacity: {passangerCapacity}\n" +
                   $"Price per kilometer: {pricePerKilometer}\n" +
                   $"Vehicle type: {type.ToString()}";
        }
    }
}
