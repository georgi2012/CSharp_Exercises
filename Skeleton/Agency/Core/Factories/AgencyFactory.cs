using System;
using Agency.Core.Contracts;
using Agency.Models.Contracts;
using Agency.Models.Vehicles.Contracts;

namespace Agency.Core.Factories
{
    public class AgencyFactory : IAgencyFactory
    {
        private static IAgencyFactory instanceHolder = new AgencyFactory();

        private AgencyFactory()
        {
        }

        public static IAgencyFactory Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        public IBus CreateBus(int passengerCapacity, decimal pricePerKilometer)
        {
            return new Bus(passengerCapacity, pricePerKilometer);
        }

        public IAirplane CreateAirplane(int passengerCapacity, decimal pricePerKilometer, bool hasFreeFood)
        {
            return new Airplane(passengerCapacity, pricePerKilometer, hasFreeFood);
        }

        public ITrain CreateTrain(int passengerCapacity, decimal pricePerKilometer, int carts)
        {
            return new Train(passengerCapacity, carts, pricePerKilometer);
        }

        public IJourney CreateJourney(string startLocation, string destination, int distance, IVehicle vehicle)
        {
            return new Journey(destination, distance, startLocation, vehicle);
        }

        public ITicket CreateTicket(IJourney journey, decimal administrativeCosts)
        {
            return new Ticket(administrativeCosts, journey);
        }
    }
}
