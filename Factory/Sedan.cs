using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Sedan : ICar
    {
        public string CarDetail()
        {
            return "A sedan is a 4-door passenger car with a separate trunk built on a three-box body";
        }
    }
}
