using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Interfaces
{
    public interface IOperation
    {
        decimal ExecOperation(float opt1, float opt2);
    }
}
