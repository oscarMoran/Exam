using PartOne.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PartOne
{
    internal class Car : TransportVehicle, IEarthTransport
    {
        private decimal _kilometers;
        public Car(decimal kilometers)
        {
            _kilometers = kilometers;
        }
        public string Go()
        {
            return $"Car is going {_kilometers}(k/h).";
        }

        public string Reverse()
        {
            return $"Car is going back.";
        }

        private void GetKilometers()
        {
            _kilometers += 100;
        }
    }
}
