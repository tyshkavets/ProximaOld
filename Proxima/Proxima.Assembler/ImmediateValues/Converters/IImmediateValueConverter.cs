namespace Proxima.Assembler.ImmediateValues.Converters
{
    public interface IImmediateValueConverter
    {
        ulong Convert(string rawLexeme);
    }
}
