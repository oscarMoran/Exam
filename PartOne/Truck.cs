using PartOne.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    internal class Truck : TransportVehicle, IEarthTransport
    {
        public string Go()
        {
            return $"Truck is going...";
        }

        public string Reverse()
        {
            return $"Truck is going back...";
        }
    }
}
