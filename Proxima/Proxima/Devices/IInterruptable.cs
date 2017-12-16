using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxima.Devices
{
    public interface IInterruptable
    {
        void HandleInterruption(uint interruptionCode, ProcessorState state);
    }
}