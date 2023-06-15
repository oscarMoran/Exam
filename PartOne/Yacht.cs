using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartOne.interfaces;

namespace PartOne
{
    public class Yacht : TransportVehicle,IWaterTransport
    {
        public void RaiseAnchor()
        {
            Console.WriteLine($"Yacht Rising anchor...");
        }

        public void RunAground()
        {
            Console.WriteLine($"Yacht Running aground...");
        }

        public void ThrowAnchor()
        {
            Console.WriteLine($"Yacht Thowwing anchor...");
        }
    }
}
