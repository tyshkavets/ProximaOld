using System.Reflection.Emit;

namespace Proxima
{
    public abstract class OperandBase : IOperand
    {
        public OperandType OperandType { get; set; }

        public abstract uint RetrieveValue();

        public abstract void SetValue(uint value);
    }
}
