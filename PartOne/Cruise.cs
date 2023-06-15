using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartOne.interfaces;

namespace PartOne
{
    public class Cruise : TransportVehicle, IWaterTransport
    {
        public void RaiseAnchor()
        {
            Console.WriteLine($"Cruise Rising anchor...");
        }

        public void RunAground()
        {
            Console.WriteLine($"Cruise Running aground...");
        }

        public void ThrowAnchor()
        {
            Console.WriteLine($"Cruise Thowwing anchor...");
        }
    }
}
