using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    public class Taxi
    {
        //properties
        public string DriveName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Drive Name : {0}", DriveName);
            Console.WriteLine("On Duty : {0} ", OnDuty ? "Yes" : "No");
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
        }

        public void PickUpPassenger ()

        {
            Console.WriteLine("\n sedang menjemput Penumpang ", DriveName);
        }
        public void DropOffPassenger()

        {
            Console.WriteLine("\n selesai mengantar Penumpang ", DriveName);
        }

    }
}
