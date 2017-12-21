using System;

namespace Proxima.Assembler.Exceptions
{
    public class DuplicateLocationNameException : Exception
    {
        public DuplicateLocationNameException() : base()
        {
            
        }

        public DuplicateLocationNameException(String message) : base(message)
        {
            
        }

        public DuplicateLocationNameException(String message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}
