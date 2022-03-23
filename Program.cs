using System;

namespace Taxi{
    class Program{
        static void Main(string[] args){
            TaxiApp Taxi = new TaxiApp();

            Taxi.DriverName = "Jono";
            Taxi.OnDuty = true;
            Taxi.NumPassenger = 10;

            Taxi.TaxiInfo();
            Taxi.PickUpPassenger();
            Taxi.DropOffPassenger();
            
            Console.ReadKey();        }
    }
}