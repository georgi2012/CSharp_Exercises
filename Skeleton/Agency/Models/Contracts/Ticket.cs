using System;
using System.Collections.Generic;
using System.Text;

namespace Agency.Models.Contracts
{
    public class Ticket : ITicket
    {
        private decimal administrativeCosts;
        private IJourney journey;

        public Ticket(decimal administrativeCosts, IJourney journey)
        {
            this.administrativeCosts = administrativeCosts;
            this.journey = journey;
        }
        public decimal AdministrativeCosts
        {
            get
            {
                return administrativeCosts;
            }
        }

        public IJourney Journey
        {
            get
            {
                return journey;
            }
        }

        public decimal CalculatePrice()
        {
            return administrativeCosts * journey.CalculateTravelCosts();
        }

        public override string ToString()
        {
            return "Ticket  ----\n" +
                   $"Destination: {journey.Destination}" +
                   $"Price: {CalculatePrice()}";
        }
    }
}
