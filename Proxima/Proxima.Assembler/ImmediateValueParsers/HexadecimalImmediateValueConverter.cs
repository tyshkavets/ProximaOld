namespace Proxima.Assembler.ImmediateValueParsers
{
    public sealed class HexadecimalImmediateValueConverter : IImmediateValueConverter
    {
        public ulong Convert(string rawLexeme)
        {
            return System.Convert.ToUInt64(rawLexeme.Replace("0x", "").Replace("h", "").Replace("_", ""), 16);
        }
    }
}
