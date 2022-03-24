using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassDanObjectTaxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //membuat objek Taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properties
            taxi.DriverName = "Jono ";
            taxi.OnDuty = " True ";
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
