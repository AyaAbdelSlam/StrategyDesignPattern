using System;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Travel Type : Auto or Bus or Train or Taxi");
            string travelType = Console.ReadLine();
            Console.WriteLine("Travel type is : " + travelType);

            var travelContext = new TravelContext();
            switch (travelType.ToLower())
            {
                //case Enum.GetName(typeof(TransportationEnum), TransportationEnum.Bus):
                case "bus":
                    travelContext.SetTravelStrategy(new BusTravelStrategy());
                    break;
                //case Enum.GetName(typeof(TransportationEnum), TransportationEnum.Train):
                case "train":
                    travelContext.SetTravelStrategy(new TrainTravelStrategy());
                    break;
                //case Enum.GetName(typeof(TransportationEnum), TransportationEnum.Taxi):
                case "taxi":
                    travelContext.SetTravelStrategy(new TaxiTravelStrategy());
                    break;
                default:
                    travelContext.SetTravelStrategy(new DefaultTravelStrategy());
                    break;

            }

            travelContext.gotoAirport();
            Console.ReadLine();
        }
    }

    public enum TransportationEnum
    {
        Bus = 0,
        Train = 1,
        Taxi = 2,
        Auto = 3
    }
}
