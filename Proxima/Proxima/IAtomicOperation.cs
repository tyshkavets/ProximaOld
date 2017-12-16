namespace Proxima
{
    interface IAtomicOperation
    {
        void RunAtomicOperation(ProcessorEmulation processorEmulation);
        void UpdateProgramCounter(ProcessorState state);
        bool DoesRequireOperands();
    }
}
