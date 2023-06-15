using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Deportivo : ICar
    {
        public string CarDetail()
        {
            return "A sports car is a car designed with an emphasis on dynamic performance, such as handling, acceleration, top speed, the thrill of driving and racing capability";
        }
    }
}
