using Agency.Models.Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agency.Models.Contracts
{
    public class Journey : IJourney
    {
        private string destination;
        private string startLocation;
        private int distance;
        IVehicle vehicle;

        public Journey(string dest, int dist, string startLoc, IVehicle veh)
        {
            if (startLoc.Length < 5 || startLoc.Length > 25)
            {
                throw new ArgumentException("The StartingLocation's length cannot be less than 5 or more than 25 symbols long.");
            }
            if (dest.Length < 5 || dest.Length > 25)
            {
                throw new ArgumentException("The Destination's length cannot be less than 5 or more than 25 symbols long.");
            }
            if (dist < 5 || dist > 5000)
            {
                throw new ArgumentException("The Distance cannot be less than 5 or more than 5000 kilometers.");
            }
            if(veh == null)
            {
                throw new ArithmeticException("Vehicle not set.");
            }
            startLocation = startLoc;
            destination = dest;
            distance = dist;
            vehicle = veh;
        }

        public string Destination
        {
            get
            {
                return destination;
            }
        }

        public int Distance
        {
            get
            {
                return distance;
            }
        }

        public string StartLocation
        {
            get
            {
                return startLocation;
            }
        }

        public IVehicle Vehicle
        {
            get
            {
                return vehicle;
            }
        }

        public decimal CalculateTravelCosts()
        {
            return vehicle.PricePerKilometer * distance;
        }

        public override string ToString()
        {
            return "Journey ----\n" +
                   $"Start location: {startLocation}\n" +
                   $"Destination: {destination}\n" +
                   $"Distance: {distance}\n" +
                   $"Vehicle type: {vehicle.Type}\n" +
                   $"Travel costs: {CalculateTravelCosts()}";
        }
    }
}
