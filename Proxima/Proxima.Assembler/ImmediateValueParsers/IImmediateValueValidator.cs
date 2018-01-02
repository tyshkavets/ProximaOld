namespace Proxima.Assembler.ImmediateValueParsers
{
    public interface IImmediateValueValidator
    {
        bool IsValidLexeme(string rawLexeme);
    }
}
