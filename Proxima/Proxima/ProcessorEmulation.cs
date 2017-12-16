namespace Proxima
{
    class ProcessorEmulation
    {
        private byte[] _physicalMemory;
        private ProcessorState _processorState;

        public ProcessorEmulation(int physicalMemorySize)
        {
            _physicalMemory = new byte[physicalMemorySize];
        }

        public void ExecuteInstruction()
        {
            var operationCode = _physicalMemory[_processorState.PC];

            // Execute operation
            // TODO: Delay for planned amount of simulated ticks
            // Move PC
        }

        public byte ReadPhysicalMemory(ulong address)
        {
            return _physicalMemory[address];
        }
    }
}
