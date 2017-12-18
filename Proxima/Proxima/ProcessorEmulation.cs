using Proxima.Devices;

namespace Proxima
{
    class ProcessorEmulation
    {
        private IMemoryInputOutputDevice _physicalMemory;
        private ProcessorState _processorState;

        public ProcessorEmulation()
        {
            _physicalMemory = new SimpleMemoryInputOutputDevice();
        }

        public void ExecuteInstruction()
        {
            var operationCode = _physicalMemory.ReadByteValue(_processorState.PC);

            // Execute operation
            // TODO: Delay for planned amount of simulated ticks
            // Move PC
        }

        public byte ReadPhysicalMemory(uint address)
        {
            return _physicalMemory.ReadByteValue(address);
        }
    }
}
