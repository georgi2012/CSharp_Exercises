using System;
using System.Collections.Generic;
using System.Text;

namespace Agency.Models.Vehicles.Contracts
{
    public class Train : Vehicle, ITrain
    {
        //fields
        private int carts;
 

        // properties

        public int Carts
        {
            get
            {
                return carts;
            }
        }


        public Train(int pasCapacity, int carts, decimal price)
            :base(pasCapacity,price,VehicleType.Land)
        {
            if (pasCapacity < 30 || pasCapacity > 150)
            {
                throw new ArgumentException("A train cannot have less than 30 passengers or more than 150 passengers.");
            }
            if (carts < 1 || carts > 15)
            {
                throw new ArgumentException("A train cannot have less than 1 cart or more than 15 carts.");
            }
            this.carts = carts;
         
        }

        public override string ToString()
        {
            return "Train ----\n" +
                   $"Passenger capacity: {passangerCapacity}\n" +
                   $"Price per kilometer: {pricePerKilometer}\n" +
                   $"Vehicle type: {type.ToString()}\n" +
                   $"Carts amount: {carts}";
        }
    }
}
