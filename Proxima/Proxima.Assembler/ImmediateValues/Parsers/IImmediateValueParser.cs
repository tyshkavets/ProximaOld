namespace Proxima.Assembler.ImmediateValues.Parsers
{
    public interface IImmediateValueParser
    {
        (bool CanBeParsed, ulong? Value) ParseLexeme(string rawLexeme);
    }
}