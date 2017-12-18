using System;
using Proxima.Utilities;

namespace Proxima.Devices
{
    public class SimpleMemoryInputOutputDevice : IMemoryInputOutputDevice
    {
        private byte[] _memory;

        public SimpleMemoryInputOutputDevice()
        {
            _memory = new byte[1000000];
        }

        public byte ReadByteValue(uint address)
        {
            return _memory[address];
        }

        public ushort ReadWordValue(uint address)
        {
            return _memory.GetWordValue(address);
        }

        public uint ReadDwordValue(uint address)
        {
            return _memory.GetDwordValue(address);
        }

        public void WriteByteValue(uint address, byte value)
        {
            throw new NotImplementedException();
        }

        public void WriteWordValue(uint address, ushort value)
        {
            throw new NotImplementedException();
        }

        public void WriteDwordValue(uint address, uint value)
        {
            throw new NotImplementedException();
        }
    }
}
