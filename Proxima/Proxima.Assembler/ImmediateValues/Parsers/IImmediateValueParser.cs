namespace Proxima.Assembler.ImmediateValues.Parsers
{
    public interface IImmediateValueParser
    {
        (bool, ulong?) ParseLexeme(string rawLexeme);
    }
}