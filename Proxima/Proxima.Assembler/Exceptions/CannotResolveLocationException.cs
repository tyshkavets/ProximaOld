using System;

namespace Proxima.Assembler.Exceptions
{
    public class CannotResolveLocationException : Exception
    {
        public CannotResolveLocationException() : base()
        {
            
        }

        public CannotResolveLocationException(String message) : base(message)
        {
            
        }

        public CannotResolveLocationException(String message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
