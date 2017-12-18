namespace Proxima.Devices
{
    public interface IInterruptable
    {
        void HandleInterruption(uint interruptionCode, ProcessorState state);
    }
}