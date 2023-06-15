using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    public class TransportVehicle
    {
        public float Speed { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int PeopleNumberSupported { get; set; }

        public static void TurnOn(string name)
        {
            Console.WriteLine($"Turning on {name}");
        }
        public static void TurnOff(string name)
        {
            Console.WriteLine($"Turning off {name}");
        }
        public string GeneralInformation()
        {
            return $"{Name} go with speed of {Speed}, and its capacity is {PeopleNumberSupported}, from  {Origin} to {Destination} \n details: \n \n  {Description}.";
        }
    }
}
