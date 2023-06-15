using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne.interfaces
{
    internal interface IWaterTransport
    {
        void RaiseAnchor();
        void ThrowAnchor();
        void RunAground();
    }
}
