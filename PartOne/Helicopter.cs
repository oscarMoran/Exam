using PartOne.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    public class Helicopter : TransportVehicle, IAirTransport
    {
        public string Land()
        {
            return "Helicopter landing";
        }

        public string Rise()
        {
            return "Helicopter raising";
        }
    }
}
