using System;

namespace Proxima.Assembler.Exceptions
{
    public class CannotParseOperandLexemeException : Exception
    {
        public CannotParseOperandLexemeException() : base()
        {
            
        }

        public CannotParseOperandLexemeException(string message) : base(message)
        {
            
        }

        public CannotParseOperandLexemeException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
