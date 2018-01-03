namespace Proxima.Assembler.ImmediateValues.Converters
{
    public sealed class BinaryImmediateValueConverter : IImmediateValueConverter
    {
        public ulong Convert(string rawLexeme)
        {
            return System.Convert.ToUInt64(rawLexeme.Replace("0b", "").Replace("b", "").Replace("_", ""), 2);
        }
    }
}