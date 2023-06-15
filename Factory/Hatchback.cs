using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Hatchback : ICar
    {
        public string CarDetail()
        {
            return "hatchback is a 4-door vehicle assembled on a two-box body with a tailgate that flips up.";
        }
    }
}
