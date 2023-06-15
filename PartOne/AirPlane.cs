using PartOne.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    public class AirPlane : TransportVehicle, IAirTransport
    {
        public string Land()
        {
            return "Airplane landing";
        }

        public string Rise()
        {
            return "Airplane raising";
        }
    }
}
