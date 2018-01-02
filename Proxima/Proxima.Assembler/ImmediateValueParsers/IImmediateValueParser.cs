using System;

namespace Proxima.Assembler.ImmediateValueParsers
{
    public interface IImmediateValueParser
    {
        (bool, ulong?) ParseLexeme(String rawLexeme);
    }
}