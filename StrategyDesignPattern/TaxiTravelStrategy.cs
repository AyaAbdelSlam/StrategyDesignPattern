using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class TaxiTravelStrategy:ITravelStrategy
    {
        public void GotoAirport()
        {
            Console.WriteLine("Traveler is going to Airport by Taxi and will be charged Rs 600");
        }
    }
}
