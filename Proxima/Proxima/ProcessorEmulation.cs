namespace Proxima
{
    class ProcessorEmulation
    {
        private int[] _physicalMemory;
        private ProcessorState _processorState;

        public ProcessorEmulation(int physicalMemorySize)
        {
            _physicalMemory = new int[physicalMemorySize];
        }

        public void ExecuteInstruction()
        {
            var operationCode = _physicalMemory[_processorState.PC];

            // Execute operation
            // TODO: Delay for planned amount of simulated ticks
            // Move PC
        }
    }
}
