namespace Proxima.Assembler.ImmediateValueParsers
{
    public interface IImmediateValueConverter
    {
        ulong Convert(string rawLexeme);
    }
}
