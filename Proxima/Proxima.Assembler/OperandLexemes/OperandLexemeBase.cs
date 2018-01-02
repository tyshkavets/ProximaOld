namespace Proxima.Assembler.OperandLexemes
{
    public abstract class OperandLexemeBase : IOperandLexeme
    {
        public OperandType Type { get; set; }

        protected OperandLexemeBase(OperandType type)
        {
            Type = type;
        }

        protected abstract void Parse(string rawLexeme);
    }
}
