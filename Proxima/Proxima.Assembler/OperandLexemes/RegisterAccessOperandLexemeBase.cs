namespace Proxima.Assembler.OperandLexemes
{
    public abstract class RegisterAccessOperandLexemeBase : OperandLexemeBase
    {
        protected string RegisterLexeme { get; set; }

        protected RegisterAccessOperandLexemeBase(OperandType type) : base(type)
        {
        }
    }
}
