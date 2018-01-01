using System;

namespace Proxima.Assembler.Exceptions
{
    public class UnknownOpcodeLexemeException : Exception
    {
        public UnknownOpcodeLexemeException() : base()
        {
            
        }

        public UnknownOpcodeLexemeException(String message) : base(message)
        {
            
        }

        public UnknownOpcodeLexemeException(String message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
