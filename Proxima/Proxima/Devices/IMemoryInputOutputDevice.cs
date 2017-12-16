using System;

namespace Proxima.Devices
{
    interface IMemoryInputOutputDevice
    {
        byte ReadByteValue(uint address);
        UInt16 ReadWordValue(uint address);
        UInt32 ReadDwordValue(uint address);

        void WriteByteValue(uint address, byte value);
        void WriteWordValue(uint address, UInt16 value);
        void WriteDwordValue(uint address, UInt32 value);
    }
}