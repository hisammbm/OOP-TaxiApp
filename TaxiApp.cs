using System;

namespace Taxi{
    class TaxiApp{
        public string? DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo(){
            string duty;

            if(OnDuty){
                duty = "Yes";
            }else{
                duty = "No";
            }

            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On duty : {0}", duty);
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
            Console.WriteLine();
        }

        public void PickUpPassenger(){
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger(){
            Console.WriteLine("{0} sedang mengantar penumpang", DriverName);
        }
    }
}