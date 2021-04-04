using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    public class TravelContext
    {
        private ITravelStrategy _travelStrategy;
        public void SetTravelStrategy(ITravelStrategy travelStrategy)
        {
            _travelStrategy = travelStrategy;
        }


        public void gotoAirport()
        {
            _travelStrategy.GotoAirport();
        }
    }
}
