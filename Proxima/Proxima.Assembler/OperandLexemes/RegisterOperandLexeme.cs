using Proxima.Assembler.Exceptions;

namespace Proxima.Assembler.OperandLexemes
{
    public class RegisterOperandLexeme : RegisterAccessOperandLexemeBase
    {
        public RegisterOperandLexeme(OperandType type) : base(type)
        {
        }

        protected override void Parse(string rawLexeme)
        {
            if (RegisterLexemeMapping.IsRegisterLexeme(rawLexeme))
            {
                RegisterLexeme = rawLexeme;
            }
            
            throw new CannotParseOperandLexemeException($"Cannot parse operand lexeme {rawLexeme} as register operand.");
        }
    }
}
