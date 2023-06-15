using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Add : IOperation
    {
        public decimal ExecOperation(float opt1, float opt2)
        {
            return (decimal)(opt1 + opt2);
        }
    }
}
